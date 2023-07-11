<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bill.aspx.cs" Inherits="Bill" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Complete Responsive Grocery Website Design Tutorial</title>

    <link rel="stylesheet" href="https://unpkg.com/swiper@7/swiper-bundle.min.css" />

    <!-- font awesome cdn link  -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">

    <!-- custom css file link  -->
    <link rel="stylesheet" href="style.css">
    <script language="javascript" type="text/javascript">
<!--

        function Button1_onclick() {
       
            window.print();
        }

// -->
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <!-- header section starts  -->

<header class="header">

    <a href="#" class="logo"> <i class="fas fa-shopping-basket"></i> OnlineGrocer </a>

  
    <form id="Form2" action="" class="login-form">
        <h3>Welcome</h3>
        
        <asp:Label ID="name" runat="server" Text="user name"></asp:Label>
       
    </form>

</header>

<!-- header section ends -->

<!-- home section starts  -->

<section class="home" id="home">

    <div class="content">
        <h3>fresh and <span>organic</span> products for your</h3>
       
    </div>

</section>

<!-- home section ends -->
 <div class="row">
    <div class="form-group">
<div class="table-responsive">
    <asp:gridview runat="server" id="grdTest" showfooter="True" 
        autogeneratecolumns="False" Width="100%"  
        CssClass="table table-bordered table-condensed table-responsive table-hover" 
        onrowdatabound="grdTest_RowDataBound" 
       >
        
        <AlternatingRowStyle BackColor="White" />
<HeaderStyle BackColor="#6B696B" Font-Bold="true" Font-Size="Larger" ForeColor="White" />
<RowStyle BackColor="#f5f5f5" />
<SelectedRowStyle BackColor="#669999" Font-Bold="true" ForeColor="White" /><columns>
            <asp:boundfield datafield="pname" headertext="Product Name"/>
             <asp:boundfield datafield="qty" headertext="Quntity"/>
            <asp:boundfield datafield="price" headertext="Price" footertext="Grand Total:" 
                footerstyle-font-bold="true">
<FooterStyle Font-Bold="True"></FooterStyle>
            </asp:boundfield>
            <asp:boundfield datafield="totalprice" headertext="Total" 
                footerstyle-font-bold="true">
<FooterStyle Font-Bold="True"></FooterStyle>
            </asp:boundfield>
            
       </columns>
    </asp:gridview>
    </div>
    </div>
    </div>
    </br></br>
    <center>
    <input id="Button1" type="button" value="Print" onclick="return Button1_onclick()" class="btn"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:LinkButton ID="LinkButtonBack" runat="server" class="btn" 
            onclick="LinkButtonBack_Click">Back to Home Page</asp:LinkButton>

    </center>
    </form>
    
</body>
</html>
