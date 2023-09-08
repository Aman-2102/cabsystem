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
   public class authenticationdataaccess
    {
        public bool Authenticateuser(string useremail, string userpass, out string validationmessage)
        {


            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"]
            .ToString());
            string query = "select count(*) from userdetail where useremail=@useremail";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            //cmd = new SqlCommand(query, sqlConnection);

            cmd.Parameters.AddWithValue("@useremail", useremail);
            cmd.Parameters.AddWithValue("@userpass", userpass);
            sqlConnection.Open();
            int row = (int)cmd.ExecuteScalar();

            sqlConnection.Close();
            if (row == 0)
            {
                validationmessage = "useremail not exists";
                return false;
            }
            string q = "select count(*) from userdetail where useremail=@useremail and userpass=@userpass";
            // SqlCommand cmd = new SqlCommand(q, sqlConnection);
            cmd = new SqlCommand(q, sqlConnection);

            cmd.Parameters.AddWithValue("@useremail", useremail);
            cmd.Parameters.AddWithValue("@userpass", userpass);
            sqlConnection.Open();
            row = (int)cmd.ExecuteScalar();

            sqlConnection.Close();
            validationmessage = row == 0 ? "credentials not matched" : string.Empty;
            return row > 0;
        }
    }
}
