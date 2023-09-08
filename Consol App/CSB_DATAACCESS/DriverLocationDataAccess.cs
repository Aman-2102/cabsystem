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
    public class DriverLocationDataAccess
    {
        public void InsertDriverLocation()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into DriverLocation  values (6,6,4,'yes',0)";
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
        }
    }
}
