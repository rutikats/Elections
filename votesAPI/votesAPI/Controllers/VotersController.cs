using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using votesAPI.BL;

namespace votesAPI.Controllers
{
    public class VotersController : ApiController
    {
        public HttpResponseMessage Get()
        {
            VotersBL votersBL = new VotersBL();
            //string ballot = votersBL.getBallot();
            return Request.CreateResponse(HttpStatusCode.OK,1);
        }
        public HttpResponseMessage Get(int personID,string issueDate)
        {
            string[] date = issueDate.Split('.');
            VotersBL votersBL = new VotersBL();
            string ballot = votersBL.getBallot(personID,new DateTime(int.Parse(date[2]),int.Parse(date[1]),int.Parse(date[0])));
            return Request.CreateResponse(HttpStatusCode.OK, ballot);
        }
    }
}
