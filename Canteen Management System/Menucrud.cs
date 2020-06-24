using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Canteen_Management_System;

namespace Canteen_Management_System
{
    public class Menucrud
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["CM"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }
        public Boolean ReadData()
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM dbo.MENU";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2]);
                successFlag = true;
            }
            return successFlag;

        }
        public Object RetriveData(int a)
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select cost from dbo.MENU where item_id=  @id";
            cmd.Parameters.AddWithValue("@id", a);
            con.Open();
            object cost1 = cmd.ExecuteScalar();
            return cost1;
        }
    }
}
