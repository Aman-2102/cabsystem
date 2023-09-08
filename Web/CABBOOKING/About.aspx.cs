using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Web.ClientServices;
using System.Collections.Specialized;
using System.Configuration;
using CSB_DATAACCESS;
namespace CABBOOKING
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void button_login_Click(object sender, EventArgs e)
        {
            string useremail = txtemail.Text;
            string userpass = txtpass.Text;

            authenticationdataaccess dAusers = new authenticationdataaccess();


            bool exist = dAusers.Authenticateuser(useremail, userpass, out string validationmessage);
            if (exist) {
                Session["usersname"] = useremail;
                Response.Redirect("booking.aspx");
            }
            else {
                lblError.Text = validationmessage;
            }

        }
    }
    }
