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
    public partial class Login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["CN"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


            }
        }
     
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", txtuser.Text);
                cmd.Parameters.AddWithValue("@Password", txtpass.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Session["user"] = txtuser.Text;
                    Response.Write("<script>alert('Login Successful')</script>");

                }
                else
                {
                    Response.Write("<script>alert('Login Failed')</script>");
                }
            }

            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
    
}