using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canteen_Management_System;

namespace Canteen_Management_System
{
    class Ordercrud
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["CM"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }
        public int Count()
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select count(*) from dbo.ORDER_DETAILS ";
            con.Open();
            object count = cmd.ExecuteScalar();
            int oid = Convert.ToInt32(count);
            return oid;

        }
        public Boolean CreateData(Order o)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
  
            cmd.CommandText = "Insert into dbo.ORDER_DETAILS values (@oid ,@a,@b,@t,@stat)";
            cmd.Parameters.AddWithValue("@oid", o.OrderId);
            cmd.Parameters.AddWithValue("@a", o.ItemId);
            cmd.Parameters.AddWithValue("@b", o.Quantity);
            cmd.Parameters.AddWithValue("@t", o.Total);
            cmd.Parameters.AddWithValue("@stat", o.Status);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean AcceptorReject()
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PENDING_ORDERS";
            //cmd.Parameters.AddWithValue("@oid", o.OrderId);
            //cmd.Parameters.AddWithValue("@a", o.ItemId);
            //cmd.Parameters.AddWithValue("@b", o.Quantity);
            //cmd.Parameters.AddWithValue("@t", o.Total);
            //cmd.Parameters.AddWithValue("@stat", o.Status);
            con.Open();
            //int count = cmd.ExecuteNonQuery();
            SqlDataReader drive = cmd.ExecuteReader();

            while (drive.Read())
            {
                Console.WriteLine(drive[0] + " " + drive[1] + " " + drive[2] + " " + drive[3] + " " + drive[4]);
                successFlag = true;
            }
            return successFlag;

        }
        public int  UpdateOrderStatus(int OrderId, string status)
        {
            //Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UPDATE_ORDER";
            cmd.Parameters.AddWithValue("@ORDER_ID", OrderId);
            //cmd.Parameters.AddWithValue("@a", o.ItemId);
            //cmd.Parameters.AddWithValue("@b", o.Quantity);
            //cmd.Parameters.AddWithValue("@t", o.Total);
            cmd.Parameters.AddWithValue("@ORDER_STATUS", status);
            con.Open();

            int drive = cmd.ExecuteNonQuery();
            return drive;

            /*while (drive.Read())
            {
                Console.WriteLine(drive[0] + " " + drive[1] + " " + drive[2] + " " + drive[3] + " " + drive[4]);
                successFlag = true;
            }
            return successFlag;*/

        }

        public Boolean ReadData()
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM dbo.ORDER_DETAILS;";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4]);
                successFlag = true;
            }
            return successFlag;

        }

    }
}

