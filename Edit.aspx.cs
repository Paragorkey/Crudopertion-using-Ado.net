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
    public partial class Edit : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["CN"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"].ToString();
            if (!IsPostBack)
            {
      

                fetchDate(id);
            }
        }
        public void fetchDate(string id)
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Name,Class,age from UserRegistrationLogin where id='" + id + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                txtname.Text = dt.Rows[0]["Name"].ToString();
                txtclass.Text = dt.Rows[0]["Class"].ToString();
                txtage.Text = dt.Rows[0]["age"].ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
    
        protected void btnupdate_Click(object sender, EventArgs e)
        {

            string id = Request.QueryString["id"].ToString();
            SqlConnection con = new SqlConnection(cs);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update UserRegistrationLogin set Name=@Name,Class=@Class,age=@age where id='"+id+"'", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", txtname.Text);
                    cmd.Parameters.AddWithValue("@Class", txtclass.Text);
                    cmd.Parameters.AddWithValue("@age", txtage.Text);
                  
                    int flag = cmd.ExecuteNonQuery();
                    if (flag > 0)
                    {

                        Response.Write("<script>alert('Student Details updated Successfully')</script>");
                        // Response.Redirect("Registration.aspx?<script>alert('Student Details Saved Successfully')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Updation  Failed')</script>");
                    }
                }
                catch (Exception ex)
                {

                }
            
        }
    }
}
