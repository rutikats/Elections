using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using votesAPI.DL;

namespace votesAPI.BL
{
    public class VotersBL
    {
        public string getBallot(int personID, DateTime issueDate)
        {
            VotersDL votersDL = new VotersDL();
            string ballot = votersDL.getspBallot("spGetKalpiInfo",personID,issueDate);
            return ballot;
        }
    }
}