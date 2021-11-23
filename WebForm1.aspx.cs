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
    public partial class WebForm1 : System.Web.UI.Page
    {

        int currentIMG;
        public void AddTagQuery(string tag ,int imageID, int userid)
        {
            String connString, output = "";
            Login userID = new Login();
            connString = @"Server=tcp:sp323project.database.windows.net,1433;Initial Catalog=CMPG323;Persist Security Info=False;User ID=sp;Password=Pottie99?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand com;
            SqlDataReader dr;
            SqlDataAdapter da = new SqlDataAdapter();
            string sql = "INSERT INTO Tags (Description,ImageID,UserID,Date) Values("+tag+","+currentIMG.ToString()+","+userid+","+DateTime.Now+")";
            con.Open();


            com = new SqlCommand(sql, con);
            da.UpdateCommand = new SqlCommand(sql, con);
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();

        }
        
        public void deleteImageQuery()
        {
            String connString, output = "";
            Login userID = new Login();
            connString = @"Server=tcp:sp323project.database.windows.net,1433;Initial Catalog=CMPG323;Persist Security Info=False;User ID=sp;Password=Pottie99?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand com;
            SqlDataReader dr;
            SqlDataAdapter da = new SqlDataAdapter();
            string sql = "DELETE FROM Image WHERE = "+currentIMG.ToString();
            con.Open();


            com = new SqlCommand(sql, con);
            da.UpdateCommand = new SqlCommand(sql, con);
            da.UpdateCommand.ExecuteNonQuery();
            con.Close();

        }
        public void NextImageYour()
        {
            Login userid = new Login();

            string retrurnVal = "";
            String connString, sql, output = "";

            connString = @"Server=tcp:sp323project.database.windows.net,1433;Initial Catalog=CMPG323;Persist Security Info=False;User ID=sp;Password=Pottie99?;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection con = new SqlConnection(connString);
            SqlCommand com;
            SqlDataReader dr;
            SqlDataAdapter da = new SqlDataAdapter();
            sql = "SELECT * from (SELECT * FROM User NATURAL JOIN Images ON UserId=UserID) WHERE UserID="+userid.User_id.ToString() ;
            con.Open();


            com = new SqlCommand(sql, con);
            da.UpdateCommand = new SqlCommand(sql, con);

            dr = com.ExecuteReader();
            dr.Read();
            nametx.Text= dr.GetValue(6).ToString();
            locationtx.Text = dr.GetValue(7).ToString();
            lblDate.Text = dr.GetValue(8).ToString();
            currentIMG= int.Parse(dr.GetValue(5).ToString());

            sql = "SELECT * FROM Tags WHERE ImageID=" + currentIMG.ToString();
            com = new SqlCommand(sql, con);
            da.UpdateCommand = new SqlCommand(sql, con);

            dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListBoxTags.Items.Add(dr.GetValue(0).ToString()+ " " + dr.GetValue(2).ToString()+ " "+dr.GetValue(3).ToString());
            }


            con.Close();

            

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Login userID = new Login();
            AddTagQuery(addTagtx.Text,currentIMG,userID.User_id);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            deleteImageQuery();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            NextImageYour();
        }
    }
}