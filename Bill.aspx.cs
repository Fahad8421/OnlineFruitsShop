using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Bill : System.Web.UI.Page
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
        if (!IsPostBack)
        {

            bindData();
            //calctotal();
        }
    }
    protected void grdTest_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            
            e.Row.Cells[0].Text = "Product Name";
            e.Row.Cells[1].Text = "Quntity(Gram/Pices)";
            e.Row.Cells[2].Text = "Price";
            e.Row.Cells[3].Text = "Total Price";

        }
    }
    public void bindData()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
        string cmdText = "select pname,qty,price,totalprice from tbl_productcart where uname='" + name.Text + "'";
        SqlDataAdapter adp = new SqlDataAdapter(cmdText, con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        grdTest.DataSource = ds;

        double totalSalary = 0;
        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            totalSalary += Convert.ToDouble(dr["totalprice"]);
        }

        //--- Here 3 is the number of column where you want to show the total.  
        grdTest.Columns[3].FooterText = totalSalary.ToString();

        //--- Make sure you bind gridview after writing total into footer.
        grdTest.DataBind();

        con.Close();
        adp.Dispose();
        ds.Dispose();
    }

    protected void LinkButtonBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}