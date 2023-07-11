using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Configuration;

public partial class MyCart : System.Web.UI.Page
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
   
    protected void gv_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.Cells[0].Text = "Action";
            e.Row.Cells[1].Text = "Product Name";
            e.Row.Cells[2].Text = "Quntity(Gram/Pices)";
            e.Row.Cells[3].Text = "Price";
            e.Row.Cells[4].Text = "Total Price";
          
        }
    }
    protected void gv_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    public void bindData()
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
    string cmdText = "select pname,qty,price,totalprice from tbl_productcart where uname='"+name.Text+"'";
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
    grdTest.Columns[4].FooterText = totalSalary.ToString();
 
    //--- Make sure you bind gridview after writing total into footer.
    grdTest.DataBind();
 
    con.Close();
    adp.Dispose();
    ds.Dispose();
}
    
  
    protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void grdTest_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (lblpname.Text == "")
        {
            Response.Write("<script>alert('Select the product ')</script>");
            return;
        }
        else
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("delete from tbl_productcart where pname='" + lblpname.Text + "' and uname='" + name.Text + "'", con);
            con.Open();
            int id = cmd.ExecuteNonQuery();
            con.Close();
            bindData();
            lblpname.Text = "";
        }
    }
    protected void grdTest_RowDataBound(object sender, GridViewRowEventArgs e)
    {
      
    }
    protected void grdTest_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = grdTest.SelectedRow;
        lblpname.Text = row.Cells[2].Text;
         
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
       
    }
    protected void btnFinalTotal_Click(object sender, EventArgs e)
    {
       
    }
    protected void LinkButtonBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
    protected void LinkButtonConformBill_Click(object sender, EventArgs e)
    {
        Response.Redirect("Bill.aspx");
    }
}