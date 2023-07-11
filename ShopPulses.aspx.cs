using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class ShopPulses : System.Web.UI.Page
{
    SqlConnection cn;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["uname"] != null)
        {
            name.Text = Session["uname"].ToString();
        }
        else
        {
            Response.Redirect("IndexPage.aspx");
        }
    }
    protected void LinkButtonMasoor_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Masoor");
            cmd.Parameters.AddWithValue("@uname", name.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql1 = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql1, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Masoor");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 80);
                cmd.Parameters.AddWithValue("@totalprice", 80);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Write("<script>alert('Product added into cart ')</script>");
            }
            else
            {
                Response.Write("<script>alert('Product already present in cart')</script>");

            }
        }
        catch (Exception ex)
        {

        }
    }
    protected void LinkButtonToorDal_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "ToorDal");
            cmd.Parameters.AddWithValue("@uname", name.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql1 = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql1, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "ToorDal");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 105);
                cmd.Parameters.AddWithValue("@totalprice", 105);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Write("<script>alert('Product added into cart ')</script>");
            }
            else
            {
                Response.Write("<script>alert('Product already present in cart')</script>");

            }
        }
        catch (Exception ex)
        {

        }
    }
    protected void LinkButtonMothBeans_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "MothBeans");
            cmd.Parameters.AddWithValue("@uname", name.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql1 = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql1, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "MothBeans");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 80);
                cmd.Parameters.AddWithValue("@totalprice", 80);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Write("<script>alert('Product added into cart ')</script>");
            }
            else
            {
                Response.Write("<script>alert('Product already present in cart')</script>");

            }
        }
        catch (Exception ex)
        {

        }
    }
    protected void LinkButtonKidneyBeans_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "KidneyBeans");
            cmd.Parameters.AddWithValue("@uname", name.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql1 = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql1, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "KidneyBeans");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 100);
                cmd.Parameters.AddWithValue("@totalprice", 100);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Write("<script>alert('Product added into cart ')</script>");
            }
            else
            {
                Response.Write("<script>alert('Product already present in cart')</script>");

            }
        }
        catch (Exception ex)
        {

        }
    }
    protected void LinkButtonChawli_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Chawli");
            cmd.Parameters.AddWithValue("@uname", name.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql1 = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql1, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Chawli");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 80);
                cmd.Parameters.AddWithValue("@totalprice", 80);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Write("<script>alert('Product added into cart ')</script>");
            }
            else
            {
                Response.Write("<script>alert('Product already present in cart')</script>");

            }
        }
        catch (Exception ex)
        {

        }
    }
    protected void LinkButtonRice_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Rice");
            cmd.Parameters.AddWithValue("@uname", name.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql1 = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql1, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Rice");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 110);
                cmd.Parameters.AddWithValue("@totalprice", 110);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Write("<script>alert('Product added into cart ')</script>");
            }
            else
            {
                Response.Write("<script>alert('Product already present in cart')</script>");

            }
        }
        catch (Exception ex)
        {

        }
    }
    protected void LinkButtonSoyaBeans_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "SoyaBeans");
            cmd.Parameters.AddWithValue("@uname", name.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql1 = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql1, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "SoyaBeans");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 70);
                cmd.Parameters.AddWithValue("@totalprice", 70);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Write("<script>alert('Product added into cart ')</script>");
            }
            else
            {
                Response.Write("<script>alert('Product already present in cart')</script>");

            }
        }
        catch (Exception ex)
        {

        }
    }
    protected void LinkButtonHarbara_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Harbara");
            cmd.Parameters.AddWithValue("@uname", name.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql1 = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql1, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Harbara");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 73);
                cmd.Parameters.AddWithValue("@totalprice", 73);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Write("<script>alert('Product added into cart ')</script>");
            }
            else
            {
                Response.Write("<script>alert('Product already present in cart')</script>");

            }
        }
        catch (Exception ex)
        {

        }
    }
}