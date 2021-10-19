using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace votesAPI.DL
{
    public class VotersDL
    {
        public static string cs = ConfigurationManager.ConnectionStrings["IsraelElection"].ConnectionString;
        public static SqlConnection connection = new SqlConnection(cs);
        public DataTable GetBallot(string pSp, string pParam)
        {
            DataSet ds = new DataSet();
            try
            {
                string parm = pParam.Replace("&", "&amp;");
                SqlParameter param;
                SqlDataAdapter adapter;

                connection.Open();

                SqlCommand command = new SqlCommand(pSp, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parm.Length != 0)
                {
                    param = new SqlParameter("@xmlparm", parm);
                    param.Direction = ParameterDirection.Input;
                    param.DbType = DbType.String;
                    command.Parameters.Add(param);
                }
                adapter = new SqlDataAdapter(command);
                adapter.Fill(ds, pSp);
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
            return ds.Tables[0];
        }
    }
}