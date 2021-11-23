using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPG323_P2
{
    public class OwnPage
    {
        public void VoidQuery(string sql)
        {
            String connString, output = "";

            connString = @"Server=tcp:sp323project.database.windows.net,1433;Initial Catalog=CMPG323;Persist Security Info=False;User ID=sp;Password=Pottie99?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand com;
            SqlDataReader dr;
            SqlDataAdapter da = new SqlDataAdapter();
            sql = "";
            con.Open();


            com = new SqlCommand(sql, con);
            da.UpdateCommand = new SqlCommand(sql, con);
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();

        }

        public string ReturnQuery(string sql)
        {
            string retrurnVal="";
            String connString, output = "";

            connString = @"Server=tcp:sp323project.database.windows.net,1433;Initial Catalog=CMPG323;Persist Security Info=False;User ID=sp;Password=Pottie99?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand com;
            SqlDataReader dr;
            SqlDataAdapter da = new SqlDataAdapter();
            sql = "";
            con.Open();


            com = new SqlCommand(sql, con);
            da.UpdateCommand = new SqlCommand(sql, con);

            dr = com.ExecuteReader();
            while (dr.Read())
            {
                output = (dr.GetValue(3).ToString());
            }
            con.Close();

            return output;

        }




    }
}