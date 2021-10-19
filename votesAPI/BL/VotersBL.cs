using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using votesAPI.DL;

namespace votesAPI.BL
{
    public class VotersBL
    {
        public int getBallot()
        {
            VotersDL votersDL = new VotersDL();
            //int ballot = votersDL.GetBallot("spGetBallot","");
            //return ballot;
            return 1;
        }
    }
}