using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class ShopFruits : System.Web.UI.Page
{
    SqlConnection cn;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButtonApple_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Apple");
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
                cmd.Parameters.AddWithValue("@pname", "Apple");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 152);
                cmd.Parameters.AddWithValue("@totalprice", 152);

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
    protected void LinkButtonMango_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Mango");
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
                cmd.Parameters.AddWithValue("@pname", "Mango");
                cmd.Parameters.AddWithValue("@qty", 6);
                cmd.Parameters.AddWithValue("@price", 537);
                cmd.Parameters.AddWithValue("@totalprice", 537);

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
    protected void LinkButtonStrawberry_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Strawberry");
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
                cmd.Parameters.AddWithValue("@pname", "Strawberry");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 675);
                cmd.Parameters.AddWithValue("@totalprice", 675);

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
    protected void LinkButtonPapaya_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Papaya");
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
                cmd.Parameters.AddWithValue("@pname", "Papaya");
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
    protected void LinkButtonGraps_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Graps");
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
                cmd.Parameters.AddWithValue("@pname", "Graps");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 118);
                cmd.Parameters.AddWithValue("@totalprice", 118);

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
    protected void LinkButtonGuava_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Guava");
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
                cmd.Parameters.AddWithValue("@pname", "Guava");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 45);
                cmd.Parameters.AddWithValue("@totalprice", 45);

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
    protected void LinkButtonBlueBerry_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "BlueBerry");
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
                cmd.Parameters.AddWithValue("@pname", "BlueBerry");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 1468);
                cmd.Parameters.AddWithValue("@totalprice", 1468);

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
    protected void LinkButtonOrages_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Orages");
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
                cmd.Parameters.AddWithValue("@pname", "Orages");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 201);
                cmd.Parameters.AddWithValue("@totalprice", 201);

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
    protected void LinkButtonPineapple_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Pineapple");
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
                cmd.Parameters.AddWithValue("@pname", "Pineapple");
                cmd.Parameters.AddWithValue("@qty", 800);
                cmd.Parameters.AddWithValue("@price", 99);
                cmd.Parameters.AddWithValue("@totalprice", 99);

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