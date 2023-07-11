using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class ShopVagitable : System.Web.UI.Page
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
    protected bool checkincartCabbage()
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Cabbage");
            cmd.Parameters.AddWithValue("@uname", name.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
                return true;
            else
                return false;

        }
        catch (Exception ex)
        {
            return true;
        }
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        if (checkincartCabbage() == true)
        {

            try
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Cabbage");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 27);
                cmd.Parameters.AddWithValue("@totalprice", 27);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Write("<script>alert('Product added into cart ')</script>");
                // Response.Redirect("AddToCart.aspx",false);
            }
            catch (Exception ex)
            {

            }
        }
        else
            Response.Write("<script>alert('Product already present in cart')</script>");
 
    }

    protected bool checkincartCarrot()
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Carrot");
            cmd.Parameters.AddWithValue("@uname", name.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);


            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count <= 0)
                return true;
            else
                return false;

        }
        catch (Exception ex)
        {
            return true;
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (checkincartCarrot() == true)
        {

            try
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Carrot");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 31);
                cmd.Parameters.AddWithValue("@totalprice", 31);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Write("<script>alert('Product added into cart ')</script>");
                // Response.Redirect("AddToCart.aspx",false);
            }
            catch (Exception ex)
            {

            }
        }
        else
            Response.Write("<script>alert('Product already present in cart')</script>");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Onion");
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
                cmd.Parameters.AddWithValue("@pname", "Onion");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 25);
                cmd.Parameters.AddWithValue("@totalprice", 25);

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
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Tomato");
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
                cmd.Parameters.AddWithValue("@pname", "Tomato");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 53);
                cmd.Parameters.AddWithValue("@totalprice", 53);

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
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Potato");
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
                cmd.Parameters.AddWithValue("@pname", "Potato");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 20);
                cmd.Parameters.AddWithValue("@totalprice",20);

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
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Capsicum");
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
                cmd.Parameters.AddWithValue("@pname", "Capsicum");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 40);
                cmd.Parameters.AddWithValue("@totalprice", 40);

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
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Corriender");
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
                cmd.Parameters.AddWithValue("@pname", "Corriender");
                cmd.Parameters.AddWithValue("@qty", 100);
                cmd.Parameters.AddWithValue("@price", 33);
                cmd.Parameters.AddWithValue("@totalprice", 33);

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
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "LadiesFinger");
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
                cmd.Parameters.AddWithValue("@pname", "LadiesFinger");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 15);
                cmd.Parameters.AddWithValue("@totalprice", 15);

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
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Sweetcorn");
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
                cmd.Parameters.AddWithValue("@pname", "Sweetcorn");
                cmd.Parameters.AddWithValue("@qty", 2);
                cmd.Parameters.AddWithValue("@price", 40);
                cmd.Parameters.AddWithValue("@totalprice", 40);

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
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "SweetPotato");
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
                cmd.Parameters.AddWithValue("@pname", "SweetPotato");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 20);
                cmd.Parameters.AddWithValue("@totalprice", 20);

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
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Ginger");
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
                cmd.Parameters.AddWithValue("@pname", "Ginger");
                cmd.Parameters.AddWithValue("@qty", 250);
                cmd.Parameters.AddWithValue("@price", 18);
                cmd.Parameters.AddWithValue("@totalprice", 18);

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
    protected void LinkButton12_Click(object sender, EventArgs e)
    {

        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Garlic");
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
                cmd.Parameters.AddWithValue("@pname", "Garlic");
                cmd.Parameters.AddWithValue("@qty", 250);
                cmd.Parameters.AddWithValue("@price", 31);
                cmd.Parameters.AddWithValue("@totalprice", 31);

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
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Beans");
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
                cmd.Parameters.AddWithValue("@pname", "Beans");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 20);
                cmd.Parameters.AddWithValue("@totalprice", 20);

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
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Brinjal");
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
                cmd.Parameters.AddWithValue("@pname", "Brinjal");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 23);
                cmd.Parameters.AddWithValue("@totalprice", 23);

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
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Cucumber");
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
                cmd.Parameters.AddWithValue("@pname", "Cucumber");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 21);
                cmd.Parameters.AddWithValue("@totalprice", 21);

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