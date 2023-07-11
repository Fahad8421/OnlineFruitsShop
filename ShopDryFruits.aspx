<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShopDryFruits.aspx.cs" Inherits="ShopDryFruits" %>

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
 <h1 class="heading"> Original <span>DryFruits</span> </h1>

    <div class="swiper product-slider">
    <section class="categories" id="categories">

        <div class="box-container">
    
            <div class="box">
                <img src="image/almond.png" alt="">
                <h3>almond</h3>
                <p>500g Rs 655/-</p>
                <asp:LinkButton ID="LinkButtonAlmond" runat="server" class="btn" 
                    onclick="LinkButtonAlmond_Click">add to cart</asp:LinkButton>
            </div>

    
            <div class="box">
                <img src="image/apricots.jpg" alt="">
                <h3>apricot</h3>
                <p>200g Rs 300/- </p>
                <asp:LinkButton ID="LinkButtonApricot" runat="server" class="btn" onclick="LinkButtonApricot_Click" 
                  >add to cart</asp:LinkButton>
            </div>

    
            <div class="box">
                <img src="image/raisins.jpg" alt="">
                <h3>risins</h3>
                <p>500g Rs 349/-</p>
                 <asp:LinkButton ID="LinkButtonRisins" runat="server" class="btn" onclick="LinkButtonRisins_Click" 
                  >add to cart</asp:LinkButton>
            </div>

    
            <div class="box">
                <img src="image/date.jpg" alt="">
                <h3>dates</h3>
                <p>500g Rs 300/-</p>
                 <asp:LinkButton ID="LinkButtonDates" runat="server" class="btn" onclick="LinkButtonDates_Click" 
                  >add to cart</asp:LinkButton>
            </div>

    
            <div class="box">
                <img src="image/pistachio.jpg" alt="">
                <h3>pistachio</h3>
                <p>500g Rs 1000/-</p>
                 <asp:LinkButton ID="LinkButtonPistachio" runat="server" class="btn" onclick="LinkButtonPistachio_Click" 
                  >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/cashnuts.png" alt="">
                <h3>cashnuts</h3>
                <p>400g Rs700/- </p>
                 <asp:LinkButton ID="LinkButtonCashnuts" runat="server" class="btn" onclick="LinkButtonCashnuts_Click" 
                  >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/dry fig.jpg" alt="">
                <h3>dry fig</h3>
                <p>500g Rs1000/- </p>
                 <asp:LinkButton ID="LinkButtonDryFig" runat="server" class="btn" onclick="LinkButtonDryFig_Click" 
                  >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/walnut.jpg" alt="">
                <h3>walnut</h3>
                <p>500g Rs1099/- </p>
                 <asp:LinkButton ID="LinkButtonWalnut" runat="server" class="btn" onclick="LinkButtonWalnut_Click" 
                  >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/makhane.jpg" alt="">
                <h3>Mkhane</h3>
                <p>500g Rs1000/- </p>
                 <asp:LinkButton ID="LinkButtonMkhane" runat="server" class="btn" onclick="LinkButtonMkhane_Click" 
                  >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/coconut.jpg" alt="">
                <h3>coconut</h3>
                <p>1 Pc Rs30/- </p>
                 <asp:LinkButton ID="LinkButtonCoconut" runat="server" class="btn" onclick="LinkButtonCoconut_Click" 
                  >add to cart</asp:LinkButton>
            </div>
    </form>
</body>
</html>
