using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Canteen_Management_System_Asp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }
        SqlConnection con = new SqlConnection(@"Data Source = 10.0.1.7; Initial Catalog =CM; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM dbo.MENU";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();
        }
        protected void btnSubmit_Click2(object sender, EventArgs e)
        {

            Response.Redirect("Home");

        }
    }

}