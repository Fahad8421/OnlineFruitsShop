using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class IndexPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtpassword_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void txtLogin_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            con.Open();
            String sql = "select * from tbl_Registration where email=@email and password=@password";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtemail.Text = "";
                txtpassword.Text = "";
                string message = "Login is Done!!!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                string name = txtemail.Text.Trim();
                Session["uname"] = dr["email"];
                //Session["name"] = name;
               Response.Redirect("HomePage.aspx");
                
                
            }
            else
            {
                txtemail.Text = "";
                txtpassword.Text = "";
                string message = "Somthing wrong try again or create new Account!!!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

                Response.Redirect("IndexPage.aspx",false);
                
            }

          }

        catch (Exception ex)
        {
            Console.Write(ex.ToString());
        }
    }
}