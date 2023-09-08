using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Data;
using CABBOOKING;
using CSB.MODULE;
using CSB_DATAACCESS;
namespace CABBOOKING
{
    public partial class booking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            //// Generate Query
            string query = "Insert into bookingdetail values ('" + TB1.Text + "','" + TB2.Text + "','" + TB3.Text + "','" + TB4.Text + "','"+DateTime.Now+"','" + TB5.Text + "','" + TB6.Text + "','" + TB7.Text + "')";
            ////string query = "insertlookuptype";

            ////Create Command            
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            cmd.CommandType = System.Data.CommandType.Text;

            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
            //Response.Redirect("userdetail.aspx");
        }

        protected void TB5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}