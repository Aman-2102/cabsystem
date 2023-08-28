using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CSB_DATAACCESS
{
    public class spd
    {
        public void spuserdetail()
        {

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string spuserdetail = "InsertUserdetail";

            SqlCommand cmd = new SqlCommand(spuserdetail, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = "laalu";
            cmd.Parameters.Add("@GENDER", SqlDbType.VarChar).Value = "m";
            cmd.Parameters.Add("@WALLETAMOUNT", SqlDbType.Int).Value = 900;
            cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "I";
            sqlconnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlconnection.Close();
            // Create connection string and assing to class
            //SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            //// Generate Query
            //string query = "Insert into UserDetail values (2,'aman','M',900)";
            ////string query = "insertlookuptype";

            ////Create Command            
            //SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            ////cmd.CommandType = System.Data.CommandType.Text;

            //sqlConnetion.Open();
            //int rowaffected = cmd.ExecuteNonQuery();
            //sqlConnetion.Close();
        }
    } 
}
