using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CSB_DATAACCESS;

namespace CABBOOKING
{
    public partial class gridview : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            spd oj = new spd();
            

            Repeater1.DataSource = oj.getdata();
            Repeater1.DataBind();

            //using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString()))
            //{
            //    sqlConnection.Open();

            //    SqlDataAdapter da = new SqlDataAdapter("select * from userdetail", sqlConnection);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    GridView1.DataSource = dt;
            //    GridView1.DataBind(); 


            //}
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}