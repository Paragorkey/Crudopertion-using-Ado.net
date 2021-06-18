using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CRUDUSINGBASICASP
{
    public partial class Dashboard : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["CN"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Showdata();
            }
        }
      
        public void Showdata()
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select id,Name,Class,age,Gender,Country,State,City,Schoolname,Created_date from UserRegistrationLogin", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                con.Close();
            }
            catch
            {

            }
            finally
            {

            }
        }

        

        protected void btnEdit_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
           // int result = Convert.ToInt32(id);
           
            Response.Redirect("Edit.aspx?id=" + id);
        }

        protected void btnDelete_Command(object sender, CommandEventArgs e)
        {
            string id = e.CommandArgument.ToString();
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from UserRegistrationLogin where id='" + id + "'", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                Showdata();
                con.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}