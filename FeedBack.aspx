﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FeedBack.aspx.cs" Inherits="FeedBack" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>vegitables</title>
     <link rel="stylesheet" href="https://unpkg.com/swiper@7/swiper-bundle.min.css" />

    <!-- font awesome cdn link  -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">

    <!-- custom css file link  -->
    <link rel="stylesheet" href="style.css">
</head>
<body>
<form runat=server>
   <!-- header section starts  -->

<header class="header">

    <a href="#" class="logo"> <i class="fas fa-shopping-basket"></i> OnlineGrocer </a>

    <nav class="navbar">
        <a href="#home">home</a>
        <a href="#features">features</a>
        <a href="#products">products</a>
        <a href="#categories">categories</a>
        <!-- <a href="#feedback">feedback</a> -->
        <!-- <a href="#blogs">blogs</a> -->
    </nav>

    <div class="icons">
        <div class="fas fa-bars" id="menu-btn"></div>
        <div class="fas fa-search" id="search-btn"></div>
        <div class="fas fa-shopping-cart" id="cart-btn"></div>
        <div class="fas fa-user" id="login-btn"></div>
          <a href="IndexPage.aspx" class=btn>Logout</a>
         
    </div>

    <form action="" class="search-form">
        <input type="search" id="search-box" placeholder="search here...">
        <label for="search-box" class="fas fa-search"></label>
    </form>

    <div class="shopping-cart">
        <div class="box">
            <i class="fas fa-trash"></i>
            <img src="image/cart-img-1.png" alt="">
            <div class="content">
                <h3>watermelon</h3>
                <span class="price">1 pc(1-3kg) RS42/-</span>
                <span class="quantity">qty : 1</span>

            </div>
        </div>
        <div class="box">
            <i class="fas fa-trash"></i>
            <img src="image/cart-img-2.png" alt="">
            <div class="content">
                <h3>onion</h3>
                <span class="price">1kg Rs25/-</span>
                <span class="quantity">qty : 1</span>
            </div>
        </div>
        
        </div>         

    <form id="Form2" action="" class="login-form">
        <h3>Welcome</h3>
        
        <asp:Label ID="name" runat="server" Text="user name"></asp:Label>
       
    </form>

</header>

<!-- header section ends -->
<section class="home" id="home">

    <div class="content">
        <h3>fresh and <span>organic</span> products for your</h3>
        <!-- <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aliquam libero nostrum veniam facere tempore nisi.</p> 
        <a href="Registration.aspx" class="btn">Register</a>-->
    </div>

</section>
   <form id="Form1" action="" class="login-form">
   <asp:Button ID="Button1" class="btn" runat="server" Text="Button" />
   <asp:TextBox ID="TextBox1" class="box" runat="server"></asp:TextBox>
   </form>
    </form>
</body>
</html>
