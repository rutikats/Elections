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
            int ballot = votersBL.getBallot();
            return Request.CreateResponse(HttpStatusCode.OK,ballot);
        }
    }
}
