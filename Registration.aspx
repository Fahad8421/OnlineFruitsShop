<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
        <title> Rsegistration Form</title>

        <!-- custom css file link  -->
     <link rel="stylesheet" href="style.css">
     <style>
input#txtfname{
    width: 300px;
    border: 1px solid #ddd;
    border-radius: 3px;
    outline: 0;
    padding: 7px;
    background-color: #fff;
    box-shadow: inset 1px 2px 5px rgba(0,0,0,0.3);
}
input#txtlname{
    width: 300px;
    border: 1px solid #ddd;
    border-radius: 3px;
    outline: 0;
    padding: 7px;
    background-color: #fff;
    box-shadow: inset 1px 2px 5px rgba(0,0,0,0.3);
}
input#txtemail{
    width: 300px;
    border: 1px solid #ddd;
    border-radius: 3px;
    outline: 0;
    padding: 7px;
    background-color: #fff;
    box-shadow: inset 1px 2px 5px rgba(0,0,0,0.3);
}
input#txtmobno{
    width: 300px;
    border: 1px solid #ddd;
    border-radius: 3px;
    outline: 0;
    padding: 7px;
    background-color: #fff;
    box-shadow: inset 1px 2px 5px rgba(0,0,0,0.3);
}
input#txtaddress{
    width: 300px;
    border: 1px solid #ddd;
    border-radius: 3px;
    outline: 0;
    padding: 7px;
    background-color: #fff;
    box-shadow: inset 1px 2px 5px rgba(0,0,0,0.3);
}
input#txtpcode{
    width: 300px;
    border: 1px solid #ddd;
    border-radius: 3px;
    outline: 0;
    padding: 7px;
    background-color: #fff;
    box-shadow: inset 1px 2px 5px rgba(0,0,0,0.3);
}
input#txtpassword{
    width: 300px;
    border: 1px solid #ddd;
    border-radius: 3px;
    outline: 0;
    padding: 7px;
    background-color: #fff;
    box-shadow: inset 1px 2px 5px rgba(0,0,0,0.3);
}
</style>
     
    </head>
<body>
        
    <div class="main">
    <div class="register">  
      <h2>Register Here</h2>
      <form id="register" metod="post" runat=server>
      <label>First Name :</label>
      <br>
      <asp:TextBox ID="txtfname" runat="server" name=name plalceholder="Enter Your First Name"></asp:TextBox>
      <br><br>
      <label>Last Name :</label>
      <br>
      <asp:TextBox ID="txtlname" runat="server" name=name plalceholder="Enter Your Last Name"></asp:TextBox>
      <br><br> 
      <label>Valid Email :</label>
      <br>
       <asp:TextBox ID="txtemail" runat="server" name=name plalceholder="Enter Your Email ID"></asp:TextBox>
       <br><br>
      <label>Phone No :</label>
      <br>
       <asp:TextBox ID="txtmobno" runat="server" name=name plalceholder="Enter Your Mobile No."></asp:TextBox>
   
      <br><br>
      <label>Address :</label>
      <br>
       <asp:TextBox ID="txtaddress" runat="server" name=name plalceholder="Enter Your Address"></asp:TextBox>
  
      <br><br>
      <label>Postal Code :</label>
      <br>
      <asp:TextBox ID="txtpcode" runat="server" name=name plalceholder="Enter Your pcode"></asp:TextBox>
      <br><br>
      <label>Password :</label>
      <asp:TextBox ID="txtpassword" runat="server" name=name plalceholder="Enter Your Mobile No."></asp:TextBox>
      <br><br>
      <asp:Button  runat="server" Text="Registration" name="submit" id="submit" 
          onclick="submit_Click"/>
     <!-- <input type="submit" value="submit"
      name="submit" id="submit">-->
      </form>
</body>
</html>
