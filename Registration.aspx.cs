using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CRUDUSINGBASICASP
{
    public partial class Registration : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["CN"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
               
                bindCountry();
                ddlState.Items.Insert(0, "------Please Select State------");
                ddlCity.Items.Insert(0, "------Please Select City------");

            }
        }
        
        public void bindCountry()
        {
            
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Country",con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ddlCountry.DataSource =dt ;
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryId";
                ddlCountry.DataBind();
                ddlCountry.Items.Insert(0, "------Please Select Country------");

                con.Close();
            }
            catch(Exception ex)
            {

            }

        }
        public void bindState()
        {

            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select StateName,State_id from State where CountryId='" + ddlCountry.SelectedValue+"'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ddlState.DataSource = dt;
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "State_id";
                ddlState.DataBind();
                ddlState.Items.Insert(0, "------Please Select State------");

                con.Close();
            }
            catch (Exception ex)
            {

            }

        }
        public void bindCity()
        {

            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Cityname,CityId from City where State_id='"+ddlState.SelectedValue+"'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ddlCity.DataSource = dt;
                ddlCity.DataTextField = "Cityname";
                ddlCity.DataValueField = "CityId";
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, "------Please Select City------");
                con.Close();
            }
            catch (Exception ex)
            {

            }

        }
       

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindState();
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindCity();
        }

        public void saveRecord()
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("saveRecord", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Class", txtclass.Text);
                cmd.Parameters.AddWithValue("@age", txtage.Text);
                cmd.Parameters.AddWithValue("gender", RadioButtonList1.SelectedItem.Text);

                cmd.Parameters.AddWithValue("@Country", ddlCountry.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@State", ddlState.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@City", ddlCity.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@Username", txtuser.Text);
                cmd.Parameters.AddWithValue("@Password", txtpass.Text);
                cmd.Parameters.AddWithValue("@SchoolName", txtSchool.Text);
                cmd.Parameters.AddWithValue("@SchoolAddress", txtAddress.Text);
                int flag = cmd.ExecuteNonQuery();
                if(flag>0)
                {

                     Response.Write("<script>alert('Student Details Saved Successfully')</script>");
                   // Response.Redirect("Registration.aspx?<script>alert('Student Details Saved Successfully')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Student Details Failed')</script>");
                }
            }
            catch(Exception ex)
            {

            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            saveRecord();
        }
    }
}