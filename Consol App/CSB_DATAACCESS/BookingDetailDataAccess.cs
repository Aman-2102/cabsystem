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
  public  class BookingDetailDataAccess
    {
        public void InsertBooking()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"]
                .ToString());
            string query = "Insert into BookingDetail values (30,1,200,1,getdate(),0,1,0)";
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
            
        }

        public int getwallet(int userid)
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"]
                .ToString());
            string q = "select WalletAmount from userdetail where userid=@userid" ;
            SqlCommand cmd = new SqlCommand(q,sqlConnetion);
            cmd.Parameters.AddWithValue("@userid",userid);
            sqlConnetion.Open();
            int count = (int)cmd.ExecuteScalar();
            sqlConnetion.Close();


            return count;
        }
        public void bookinginsert(int userid,int charge,out string msg)
        {
            msg = string.Empty;
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"]
             .ToString());
            sqlConnetion.Open();
            int count = getwallet(userid);

            if (count<charge)
            {
                msg = "wallet amount is less than charge..can't insert ";
            }

            string q = "insert into bookingdetail values(37,1,@charge,1,getdate(),0,1,0,@userid)";
            SqlCommand cmd = new SqlCommand(q,sqlConnetion);
            cmd.Parameters.AddWithValue("@charge",charge);
            cmd.Parameters.AddWithValue("@userid",userid);
                                                                                                                                    
        }
    }
}
