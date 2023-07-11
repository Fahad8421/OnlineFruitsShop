<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShopVagitable.aspx.cs" Inherits="ShopVagitable" %>

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
    <form id="form1" runat="server">
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
   <h1 class="heading"> Fresh <span>Veggies</span> </h1>

    <div class="swiper product-slider">
    <section class="categories" id="categories">

        <div class="box-container">
    
            <div class="box">
                <img src="image/cabbage.png" alt="">
                <h3>Cabbage</h3>
                <p>500g-Rs 27/-</p>
                 <asp:LinkButton ID="LinkButton5" runat="server" class="btn" onclick="LinkButton5_Click" 
                    >add to cart</asp:LinkButton>
                
            </div>
    
            <div class="box">
                <img src="image/carrot.png" alt="">
                <h3>Carrot</h3>
                <p>500g-Rs 31/-</p>
                <asp:LinkButton ID="LinkButton1" runat="server" class="btn" onclick="LinkButton1_Click" 
                    >add to cart</asp:LinkButton>
            </div>
    
            <div class="box">
                <img src="image/onion.png" alt="">
                <h3>Onion</h3>
                <p>500g-Rs 25/-</p>
                 <asp:LinkButton ID="LinkButton2" runat="server" class="btn" onclick="LinkButton2_Click" 
                    >add to cart</asp:LinkButton>
            </div>
            <div class="box">
                <img src="image/tomato.png" alt="">
                <h3>tomato</h3>
                <p>500g-Rs  53/-</p>
                 <asp:LinkButton ID="LinkButton3" runat="server" class="btn" onclick="LinkButton3_Click" 
                    >add to cart</asp:LinkButton>
            </div>
    
            <div class="box">
                <img src="image/potato.png" alt="">
                <h3>potato</h3>
                <p>500g-Rs 20/-</p>
                 <asp:LinkButton ID="LinkButton4" runat="server" class="btn" onclick="LinkButton4_Click"
                    >add to cart</asp:LinkButton>
            </div>
            <div class="box">
                <img src="image/capsicum.png" alt="">
                <h3>capsicum</h3>
                <p>500g-Rs 40/-</p>
               <asp:LinkButton ID="LinkButton6" runat="server" class="btn" onclick="LinkButton6_Click"
                    >add to cart</asp:LinkButton>
            </div>
            <div class="box">
                <img src="image/corriender.png" alt="">
                <h3>corriender</h3>
                <p>100g RS 33/- </p>
                    <asp:LinkButton ID="LinkButton7" runat="server" class="btn" onclick="LinkButton7_Click"
                    >add to cart</asp:LinkButton>
            </div>
            <div class="box">
                <img src="image/ladies fingure.png" alt="">
                <h3>ladies finger</h3>
                <p>500g-Rs 15/-</p>
                <asp:LinkButton ID="LinkButton8" runat="server" class="btn" onclick="LinkButton8_Click"
                    >add to cart</asp:LinkButton>
            </div>
           <div class="box">
                <img src="image/corn.png" alt="">
                <h3>Sweet corn</h3>
                <p>2pcs-Rs 40/-</p>
               <asp:LinkButton ID="LinkButton9" runat="server" class="btn" onclick="LinkButton9_Click"
                    >add to cart</asp:LinkButton>
            </div>
            <div class="box">
                <img src="image/sweet potato.png" alt="">
                <h3>sweet potato</h3>
                <p>500g-Rs 20/-</p>
              <asp:LinkButton ID="LinkButton10" runat="server" class="btn" onclick="LinkButton10_Click"
                    >add to cart</asp:LinkButton>
            </div>
            <div class="box">
                <img src="image/ginger.png" alt="">
                <h3>ginger</h3>
                <p>250g-Rs 18/-</p>
               <asp:LinkButton ID="LinkButton11" runat="server" class="btn" onclick="LinkButton11_Click"
                    >add to cart</asp:LinkButton>
            </div>
           <div class="box">
                <img src="image/garlic.png" alt="">
                <h3>garlic</h3>
                <p>250g-Rs 31/- </p>
                <asp:LinkButton ID="LinkButton12" runat="server" class="btn" onclick="LinkButton12_Click"
                    >add to cart</asp:LinkButton>
            </div>
            <div class="box">
                <img src="image/beans.png" alt="">
                <h3>beans</h3>
                <p>500g-Rs 20/-</p>
               <asp:LinkButton ID="LinkButton13" runat="server" class="btn" onclick="LinkButton13_Click"
                    >add to cart</asp:LinkButton>
            </div>
           <div class="box">
                <img src="image/brinjal.png" alt="">
                <h3>brinjal</h3>
                <p>500g-Rs 23/-</p>
              <asp:LinkButton ID="LinkButton14" runat="server" class="btn" onclick="LinkButton14_Click"
                    >add to cart</asp:LinkButton>
            </div>
           <div class="box">
                <img src="image/cucumber.png" alt="">
                <h3>cucumber</h3>
                <p>500g-Rs 21/-</p>
               <asp:LinkButton ID="LinkButton15" runat="server" class="btn" onclick="LinkButton15_Click"
                    >add to cart</asp:LinkButton>
            </div>
    </form>
</body>
</html>
