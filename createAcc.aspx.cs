using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CMPG323_P2
{
    public partial class createAcc : System.Web.UI.Page
    {
        public void VoidQuery(string sql)
        {
            try
            {
                String connString, output = "";

                connString = @"Server=tcp:sp323project.database.windows.net,1433;Initial Catalog=CMPG323;Persist Security Info=False;User ID=sp;Password=Pottie99?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
                SqlConnection con = new SqlConnection(connString);
                SqlCommand com;
                SqlDataReader dr;
                SqlDataAdapter da = new SqlDataAdapter();
                
                con.Open();


                com = new SqlCommand(sql, con);
                da.UpdateCommand = new SqlCommand(sql, con);
                da.UpdateCommand.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }
            

        }
        public void addUser(string usernameVal, string passwordVal, string firstVal, string lastVal)
        {
            string retrurnVal = "";
            String connString, sql, username, password ,first,last = "";
            bool val = true;

            connString = @"Server=tcp:sp323project.database.windows.net,1433;Initial Catalog=CMPG323;Persist Security Info=False;User ID=sp;Password=Pottie99?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand com;
            SqlDataReader dr;
            SqlDataAdapter da = new SqlDataAdapter();
            sql = "SELECT * FROM User ";
            con.Open();


            com = new SqlCommand(sql, con);
            da.UpdateCommand = new SqlCommand(sql, con);

            dr = com.ExecuteReader();
            while (dr.Read())
            {
                first = (dr.GetValue(1).ToString());
                password = (dr.GetValue(2).ToString());
                username = (dr.GetValue(3).ToString());
                password = (dr.GetValue(4).ToString());

                if (username == usernameVal || password == passwordVal)
                {
                    // error message
                    val = false;
                    break;
                }
               
                
                  
                    
                

            }
            con.Close();
            if (val)
            {
                VoidQuery("INSERT INTO User (FirstName,Lastname,Username,Password) Values (" + firstVal + "," + lastVal + ", " + usernameVal + "," + passwordVal + ")");
                Response.Redirect("Login.aspx");

            }
            else
            {
                // error message user already exist with user name or password.
            }



        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username, password, firstname, lastname = "";

        }
    }
}