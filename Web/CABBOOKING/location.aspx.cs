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
    public partial class location : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            int locationid = Convert.ToInt32(txtid.Text);
            string locationname = txtname.Text;
            //SqlConnection sqlConnetion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //string query = "Insert into locationtable values ('" + txtid.Text + "','" + txtname.Text + "')";
            //SqlCommand cmd = new SqlCommand(query, sqlConnetion);
            //sqlConnetion.Open();
            //int rowaffected = cmd.ExecuteNonQuery();
            //sqlConnetion.Close();

            locationMappingDataAccess obj = new locationMappingDataAccess();
            //new locationMappingDataAccess().locationmapping(locationid, locationname, out string validationmessage);
            bool exists =obj.locationmapping(locationid, locationname, out string validationmessage);
            if (exists) {

                Label3.Text = validationmessage;
            }
            //else {
            //    Label3.Text = validationmessage;
            //}


        }
    }
}