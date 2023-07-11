using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class ContactMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            con.Open();

            string sql = "insert into tbl_Contact values(@name,@email,@msg)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@msg", txtmsg.Text);
            int cnt = cmd.ExecuteNonQuery();
            if (cnt > 0)
            {
                txtname.Text = "";
                txtemail.Text = "";
                txtmsg.Text = "";

                Response.Write("<script>alert('Thank you to Contact Us')</script>");
                //Response.Redirect("IndexPage.aspx");
            }
            else
            {
                
            }

            con.Close();

        }
        catch (Exception ex)
        {
            //lblmsg.Visible = true;
            //   lblmsg.Text = ex.Message.ToString();
        }
    }
}