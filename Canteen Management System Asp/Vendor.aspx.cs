using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Canteen_Management_System_Asp
{
    public partial class Vendor : System.Web.UI.Page
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
            cmd.CommandText = "SELECT * FROM dbo.ORDER_DETAILS WHERE ORDER_STATUS = 'pending'";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();
        }
       /* public void btnSubmit_Click3()
        {
            cmd.Connection = con;
            cmd = new SqlCommand();
            cmd.Connection = con;
            int ccount = Count() + 1;
            //string status = "pending";
            cmd.CommandText = "UPADATE ORDER_DETAILS SET ORDER_STATUS = 'Accepted' WHERE ORDER_ID = @ORDER_ID";

            //cmd.Parameters.AddWithValue("@ORDER_STATUS", status);
            cmd.Parameters.AddWithValue("@ORDER_ID", ccount);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            con.Close();
        }
        public void btnSubmit_Click4()
        {
            cmd.Connection = con;
            cmd = new SqlCommand();
            cmd.Connection = con;
            int ccount = Count() + 1;
            cmd.CommandText = "UPADATE ORDER_DETAILS SET ORDER_STATUS = 'Rejected' WHERE ORDER_ID = @ORDER_ID'";
            cmd.Parameters.AddWithValue("@ORDER_ID", ccount);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            con.Close();
        }
        protected int Count()
        {
            cmd.Connection = con;
            cmd.CommandText = "Select count(*)from dbo.ORDER_DETAILS ";
            con.Open();
            object count = cmd.ExecuteScalar();
            con.Close();
            int oid = Convert.ToInt32(count);
            return oid;
        }*/
        protected void btnSubmit_Click2(object sender, EventArgs e)
        {

            Response.Redirect("Home");

        }
       

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("Home");

        }
    }
}