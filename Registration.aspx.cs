using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            con.Open();

            string sql = "insert into tbl_Registration values(@fname,@lname,@email,@mobno,@address,@postcode,@password)";
            SqlCommand cmd = new SqlCommand(sql, con);
             cmd.Parameters.AddWithValue("@fname", txtfname.Text);
             cmd.Parameters.AddWithValue("@lname", txtlname.Text);
             cmd.Parameters.AddWithValue("@email", txtemail.Text);
             cmd.Parameters.AddWithValue("@mobno", txtmobno.Text);
             cmd.Parameters.AddWithValue("@address", txtaddress.Text);
             cmd.Parameters.AddWithValue("@postcode", txtpcode.Text);
             cmd.Parameters.AddWithValue("@password", txtpassword.Text);
             int cnt = cmd.ExecuteNonQuery();
             if (cnt > 0)
             {
                 txtfname.Text = "";
                 txtlname.Text = "";
                 txtemail.Text = "";
                 txtmobno.Text = "";
                 txtaddress.Text = "";
                 txtpcode.Text = "";
                 txtpassword.Text = "";

                 string message = "Registration is Done!!!";
                 System.Text.StringBuilder sb = new System.Text.StringBuilder();
                 sb.Append("<script type = 'text/javascript'>");
                 sb.Append("window.onload=function(){");
                 sb.Append("alert('");
                 sb.Append(message);
                 sb.Append("')};");
                 sb.Append("</script>");
                 ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                 Response.Redirect("IndexPage.aspx");
                 /*lblmsg.Text = "Record Inserted";
                 txtfactfirstname.Text = "";
                 txtfactlastname.Text = "";
                 txtfactaddress.Text = "";
                 txtfactdob.Text = "";
                 txtfactgender.Text = "";
                 txtfactmoblile.Text = "";
                 txtfactaadar.Text = "";
                 txtfactusername.Text = "";
                 txtfactpassword.Text = "";
                 txtfactemailid.Text = "";
                 Response.Redirect("FacultyLogin.aspx");
                 BindGrid();*/

             }
             else
             {
               //  lblmsg.Visible = true;
                // lblmsg.Text = "Record Fail";
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