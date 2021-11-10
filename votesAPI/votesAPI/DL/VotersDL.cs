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

        public string getspBallot(string pSp, int personID, DateTime issueDate)
        {
            SqlConnection connection2 = new SqlConnection(cs);
            string b="";
            DataSet ds = new DataSet();
            try
            {
                SqlParameter personIDParam,issueDateParam;
                SqlDataAdapter adapter;
                connection2.Open();
                SqlCommand command = new SqlCommand(pSp, connection);
                command.CommandType = CommandType.StoredProcedure;
                personIDParam = new SqlParameter("@personID", personID);
                personIDParam.Direction = ParameterDirection.Input;
                personIDParam.DbType = DbType.Int64;
                issueDateParam = new SqlParameter("@issueDate", issueDate);
                issueDateParam.Direction = ParameterDirection.Input;
                issueDateParam.DbType = DbType.Date;
                command.Parameters.Add(personIDParam);
                command.Parameters.Add(issueDateParam);
                adapter = new SqlDataAdapter(command);
                int s=adapter.Fill(ds, pSp);

                if (ds.Tables[0].Rows.Count!=0)
                    b = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                else
                    b = "Details don't match";
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                connection2.Close();
                connection2.Dispose();
            }
            
            return b;
        }
    }

}