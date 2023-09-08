using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Configuration;

using System.Data;

using CSB.MODULE;
using CSB_DATAACCESS;
using static CSB_DATAACCESS.Class1;

namespace CSB_DATAACCESS
{
   public class locationMappingDataAccess 
    {
        public bool locationmapping(int LocationMappingId, string locationName, out string validationmessage)
        {

            //SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //string query = "Insert into locationtable values (@locationid,@locationname)";
            //SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            //sqlConnetion.Open();
            //int row = (int)cmd.ExecuteScalar();
            //sqlConnetion.Close();


            // Assuming ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString() points to your database connection string.

            // string LocationMappingId = Convert.ToInt32(txtid.Text); // Replace with the actual location ID from your web form.
            //string locationName = "txtname.Text"; // Replace with the actual location name from your web form.



            //using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString()))
            using (SqlConnection sqlConnection = ConnectionString.GetConnection())
            {
                sqlConnection.Open();

                string query = "INSERT INTO locationtable VALUES (@locationid, @locationname)";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);

                cmd.Parameters.AddWithValue("@locationid", LocationMappingId);
                cmd.Parameters.AddWithValue("@locationname", locationName);

                int rowsAffected = cmd.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    validationmessage = "data inserted";
                    return true;
                }
                else
                {
                    validationmessage = "data not inserted";
                    return false;
                }
            }
            
            

        }
    }
}
