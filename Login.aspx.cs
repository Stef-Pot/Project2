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
    public partial class Login : System.Web.UI.Page
    {

        public int User_id ;
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
        public Boolean ValidUser(string usernameVal, string passwordVal)
        {
            string retrurnVal = "";
            String connString, sql,username,password = "";
            bool val = false;

            connString = @"Server=tcp:sp323project.database.windows.net,1433;Initial Catalog=CMPG323;Persist Security Info=False;User ID=sp;Password=Pottie99?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand com;
            SqlDataReader dr;
            SqlDataAdapter da = new SqlDataAdapter();
            sql = "SELECT * FROM User WHERE Username="+usernameVal+" Password="+passwordVal ;
            con.Open();


            com = new SqlCommand(sql, con);
            da.UpdateCommand = new SqlCommand(sql, con);

            dr = com.ExecuteReader();
            while (dr.Read())
            {
                username = (dr.GetValue(3).ToString());
                 password= (dr.GetValue(4).ToString());

                if (username==usernameVal && password==passwordVal)
                {
                    val = true;
                    User_id= int.Parse(dr.GetValue(0).ToString());
                }
             
            }
            con.Close();

            return val;

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username, password;

            username = UsernameTX.Text;
            password = PasswordTX.Text;

            if (ValidUser(username, password))
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                //error message
            }




        }
    }
}