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
    public partial class userdetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged2(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
          string @ad = TextBox1.Text;
            //// Generate Query
            string query = "Insert into UserDetail values ('"+TextBox1.Text+"','"+TextBox2.Text+ "','" + TextBox3.Text + "'," +
                "'" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')";
            ////string query = "insertlookuptype";

            ////Create Command            
            SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            cmd.CommandType = System.Data.CommandType.Text;

            sqlConnetion.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            sqlConnetion.Close();
        }
    }
}