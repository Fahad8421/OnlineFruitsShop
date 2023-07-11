<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShopPulses.aspx.cs" Inherits="ShopPulses" %>

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

<h1 class="heading"> Fresh <span>PULSES</span> </h1>

    <div class="swiper product-slider">
    <section class="categories" id="categories">

        <div class="box-container">
    
            <div class="box">
                <img src="image/masoor.png" alt="">
                <h3>masoor</h3>
                <p>500g-Rs 80/-</p>
                 <asp:LinkButton ID="LinkButtonMasoor" runat="server" class="btn" onclick="LinkButtonMasoor_Click" 
                    >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/toor dal.png" alt="">
                <h3>toor dal</h3>
                <p>500g-Rs 105/-</p>
                <asp:LinkButton ID="LinkButtonToorDal" runat="server" class="btn" onclick="LinkButtonToorDal_Click" 
                    >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/moth beans.jpg" alt="">
                <h3>moth beans (Matki)</h3>
                <p>500g-Rs 80/-</p>
                <asp:LinkButton ID="LinkButtonMothBeans" runat="server" class="btn" onclick="LinkButtonMothBeans_Click" 
                    >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/kidney beans.jpg" alt="">
                <h3>kidney beans(Red Chawli)</h3>
                <p>500g-Rs 100/-</p>
               <asp:LinkButton ID="LinkButtonKidneyBeans" runat="server" class="btn" onclick="LinkButtonKidneyBeans_Click" 
                    >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/chawli.jpg" alt="">
                <h3>black eyed beans (Chawli)</h3>
                <p>500g-Rs 80/-</p>
                <asp:LinkButton ID="LinkButtonChawli" runat="server" class="btn" onclick="LinkButtonChawli_Click" 
                    >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/rice.jpg" alt="">
                <h3>rice</h3>
                <p>1000g Rs 110/-</p>
               <asp:LinkButton ID="LinkButtonRice" runat="server" class="btn" onclick="LinkButtonRice_Click" 
                    >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/soya beans.jpg" alt="">
                <h3>soya beans</h3>
                <p>500g Rs 70/-</p>
                <asp:LinkButton ID="LinkButtonSoyaBeans" runat="server" class="btn" onclick="LinkButtonSoyaBeans_Click" 
                    >add to cart</asp:LinkButton>
            </div>

            <div class="box">
                <img src="image/harbara.jpg" alt="">
                <h3>harbara</h3>
                <p>500g Rs 73/-</p>
                <asp:LinkButton ID="LinkButtonHarbara" runat="server" class="btn" onclick="LinkButtonHarbara_Click" 
                    >add to cart</asp:LinkButton>
            </div>
    </form>
</body>
</html>
