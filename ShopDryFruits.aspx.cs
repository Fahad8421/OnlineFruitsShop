using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class ShopDryFruits : System.Web.UI.Page
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
    protected void LinkButtonAlmond_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Almond");
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
                cmd.Parameters.AddWithValue("@pname", "Almond");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 655);
                cmd.Parameters.AddWithValue("@totalprice", 655);

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
    protected void LinkButtonApricot_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Apricot");
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
                cmd.Parameters.AddWithValue("@pname", "Apricot");
                cmd.Parameters.AddWithValue("@qty", 200);
                cmd.Parameters.AddWithValue("@price", 300);
                cmd.Parameters.AddWithValue("@totalprice", 300);

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
    protected void LinkButtonRisins_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Risins");
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
                cmd.Parameters.AddWithValue("@pname", "Risins");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 349);
                cmd.Parameters.AddWithValue("@totalprice", 349);

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
    protected void LinkButtonDates_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Dates");
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
                cmd.Parameters.AddWithValue("@pname", "Dates");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 300);
                cmd.Parameters.AddWithValue("@totalprice", 300);

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
    protected void LinkButtonPistachio_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Pistachio");
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
                cmd.Parameters.AddWithValue("@pname", "Pistachio");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 1000);
                cmd.Parameters.AddWithValue("@totalprice", 1000);

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
    protected void LinkButtonCashnuts_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Cashnuts");
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
                cmd.Parameters.AddWithValue("@pname", "Cashnuts");
                cmd.Parameters.AddWithValue("@qty", 400);
                cmd.Parameters.AddWithValue("@price", 700);
                cmd.Parameters.AddWithValue("@totalprice", 700);

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
    protected void LinkButtonDryFig_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "DryFig");
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
                cmd.Parameters.AddWithValue("@pname", "DryFig");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 1000);
                cmd.Parameters.AddWithValue("@totalprice", 1000);

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
    protected void LinkButtonWalnut_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Walnut");
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
                cmd.Parameters.AddWithValue("@pname", "Walnut");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 1099);
                cmd.Parameters.AddWithValue("@totalprice", 1099);

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
    protected void LinkButtonMkhane_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Mkhane");
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
                cmd.Parameters.AddWithValue("@pname", "Mkhane");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 1000);
                cmd.Parameters.AddWithValue("@totalprice", 1000);

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
    protected void LinkButtonCoconut_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Coconut");
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
                cmd.Parameters.AddWithValue("@pname", "Coconut");
                cmd.Parameters.AddWithValue("@qty", 1);
                cmd.Parameters.AddWithValue("@price", 30);
                cmd.Parameters.AddWithValue("@totalprice", 30);

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