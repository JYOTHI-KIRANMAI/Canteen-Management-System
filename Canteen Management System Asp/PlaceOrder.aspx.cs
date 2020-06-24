using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics.SymbolStore;
using System.Resources;

namespace Canteen_Management_System_Asp
{
    public partial class PlaceOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source = 10.0.1.7; Initial Catalog =CM; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public void btnSubmit_Click(object sender, EventArgs e)
        {
            Boolean successFlag = false;
            //con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            int ccount = Count() + 1;
            int total = OrderCost();
            string status = "Pending";

            cmd.CommandText = "Insert into dbo.ORDER_DETAILS values (@oid,@a,@b,@t,@stat)";
            cmd.Parameters.AddWithValue("@oid", ccount);
            cmd.Parameters.AddWithValue("@a", TxtId.Text);
            cmd.Parameters.AddWithValue("@b", TxtQuantity.Text);
             //int m = int.Parse(TxtQuantity.Text);
            cmd.Parameters.AddWithValue("@t", total);
            cmd.Parameters.AddWithValue("@stat", status);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            /*if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;*/

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
        }
        public int OrderCost()
        {
            cmd.Connection = con;
            cmd.CommandText = "SELECT COST FROM dbo.MENU WHERE ITEM_ID = @k";
            cmd.Parameters.AddWithValue("@k", TxtId.Text);
            con.Open();
            var cost = cmd.ExecuteScalar();
            con.Close();
            int c = Convert.ToInt32(cost);
            //int m = int.Parse(TxtQuantity.Text);
            int m = Convert.ToInt32(TxtQuantity.Text);
            int total = m * c;
            //int t = Convert.ToInt32(total);
            return total;
            
        }
        /*protected string Status()
        {
            cmd.Connection = con;
            cmd.CommandText = "SELECT ORDER_STATUS FROM dbo.ORDER_DETAILS WHERE ORDER_ID = @oid";
            con.Open();
            object status = cmd.ExecuteScalar();
            con.Close();
            return status;

        }*/

        protected void btnSubmit2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu");

        }
        
    }
}