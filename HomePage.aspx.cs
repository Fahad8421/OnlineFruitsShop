using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class HomePage : System.Web.UI.Page
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
    protected void txtpassword_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtLogin_Click(object sender, EventArgs e)
    {

    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
    
    }
    protected void btnAddToCart1_Click(object sender, EventArgs e)
    {
       
    }
    protected void btnfo1_Click(object sender, EventArgs e)
    {
        String pname = "fresh orange", price = "500g Rs201/-";
        pname = this.Context.Items["pname"].ToString();
        price = this.Context.Items["price"].ToString();
        Response.Redirect("AddToCart.aspx",false);
    }
    protected bool checkincartOrange()
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Orange");
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

    protected bool checkincartOnion()
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
        if (checkincartOrange() == true)
        {

            try
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Orange");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 201);
                cmd.Parameters.AddWithValue("@totalprice", 201);

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
        if (checkincartOnion() == true)
        {
            try
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Onion");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 25);
                cmd.Parameters.AddWithValue("@totalprice", 25);

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

    protected bool checkincartAlmond()
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
                return true;
            else
                return false;

        }
        catch (Exception ex)
        {
            return true;
        }
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        if (checkincartAlmond() == true)
        {
            try
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Almond");
                cmd.Parameters.AddWithValue("@qty", 250);
                cmd.Parameters.AddWithValue("@price", 299);
                cmd.Parameters.AddWithValue("@totalprice", 299);

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
    protected void LinkButton4_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@qty", 1);
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




    protected bool checkincartApricot()
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
        if (checkincartApricot() == true)
        {
            try
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Apricot");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 899);
                cmd.Parameters.AddWithValue("@totalprice", 899);

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
    protected bool checkincartAvocado()
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "Avocado");
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
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        if (checkincartAvocado() == true)
        {
            try
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "Avocado");
                cmd.Parameters.AddWithValue("@qty", 1);
                cmd.Parameters.AddWithValue("@price", 266);
                cmd.Parameters.AddWithValue("@totalprice", 266);

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



    protected bool checkincartAToorDal()
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
                return true;
            else
                return false;

        }
        catch (Exception ex)
        {
            return true;
        }
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {

        if (checkincartAToorDal() == true)
        {
            try
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "ToorDal");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 105);
                cmd.Parameters.AddWithValue("@totalprice", 105);

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



    protected bool checkincartMasoorDal()
    {
        cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string sql = "select * from tbl_productcart where pname=@pname and uname=@uname";
        try
        {
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@pname", "MasoorDal");
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
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        if (checkincartMasoorDal() == true)
        {
            try
            {
                cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                string sql = "insert into tbl_productcart values(@uname,@pname,@qty,@price,@totalprice)";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@uname", name.Text);
                cmd.Parameters.AddWithValue("@pname", "MasoorDal");
                cmd.Parameters.AddWithValue("@qty", 500);
                cmd.Parameters.AddWithValue("@price", 80);
                cmd.Parameters.AddWithValue("@totalprice", 80);

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
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyCart.aspx");
    }
}