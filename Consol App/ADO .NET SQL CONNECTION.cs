using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ADONetExample
{
    public class Program
    {
        SqlConnection sqlConnetion = null;
        //SqlDataAdapter apdt=null;
        public void Insertuserdetail()
        {
            // Create connection string and assing to class
             sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            // Generate Query
            string query = "Insert into UserDetail values ('jignesh','M',10)";
            //string query = "insertlookuptype";

            //Create Command            
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            //cmd.CommandType = System.Data.CommandType.Text;

            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
        }
        public void InsertDriverDetail()
        {
             sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into DriverDetail values ('meet','M')";
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
        }
        public void InsertDriverLocation()
        {
             sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into DriverLocation  values (206,501,'yes')";
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
        }
        public void InsertUserDrive()
        {
             sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into UserDrive values (5,501,503)";
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
        }
        public void InsertBooking()
        {
             sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "Insert into BookingDetail values (5,203,503,505,400)";
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
        }
        public void spuserdetail()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
             string spuserdetail = "InsertUserdetail";
            
            SqlCommand cmd = new SqlCommand(spuserdetail, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = 17;
            cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = "laalu";
            cmd.Parameters.Add("@GENDER", SqlDbType.VarChar).Value = "m";
            cmd.Parameters.Add("@WALLETAMOUNT", SqlDbType.Int).Value = 900;
            cmd.Parameters.Add("@OPType", SqlDbType.VarChar).Value = "U";
            sqlconnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlconnection.Close();
        }
        public void getfirstdata()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string retriveQuery = "select top 1 username from USERDETAIL";
            SqlCommand cmd = new SqlCommand(retriveQuery, sqlConnetion);
            cmd = new SqlCommand(retriveQuery, sqlConnetion);
            sqlConnetion.Open();
           string username = Convert.ToString(cmd.ExecuteScalar());
         
            sqlConnetion.Close();
            Console.WriteLine(username);
            Console.ReadKey();
        }
        public void allrecord()
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string retrivetable = "select * from USERDETAIL";
            
            SqlCommand cmd = new SqlCommand(retrivetable, sqlConnetion);
            sqlConnetion.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.HasRows)
            {
                while(rdr.Read())
                {
                    Console.WriteLine("{0}  {1}  {2}  {3}", rdr["userid"], rdr["username"], rdr["gender"], rdr["walletamount"]);
                   // Console.WriteLine($"{rdr["userid"]} { rdr["username"]} {rdr["gender"]} {rdr["walletamount"]}");
                }
                Console.ReadKey();
            }
           


        }
        public void dataset()
        {
            
            
               SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from userdetail; select * from driverdetail", sqlConnetion);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                Console.WriteLine("Table 1 Data");

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {

                    Console.WriteLine(row["userId"] + ",  " + row["userName"] + ",  " + row["gender"] + " " + row["walletamount"]);

                }
                Console.WriteLine();

                Console.WriteLine("Table 2 Data");

                foreach (DataRow row in dataSet.Tables[1].Rows)
                {

                    Console.WriteLine(row[0] + ",  " + row[1] + ",  " + row[2]);
                }

            }
           
        }


        static void Main(string[] args)
        {
            //new Program().Insertuserdetail();
            //new Program().InsertDriverDetail();
            //new Program().InsertDriverLocation();
            // new Program().InsertUserDrive();
            // new Program().InsertBooking();
             //new Program().spuserdetail();
            //new Program().getfirstdata();
           // new Program().allrecord();
            new Program().dataset();
        }

    }
    
}
       