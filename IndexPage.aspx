﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IndexPage.aspx.cs" Inherits="IndexPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" lang="en">
<head>
 <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Complete Responsive Grocery Website Design Tutorial</title>

    <link rel="stylesheet" href="https://unpkg.com/swiper@7/swiper-bundle.min.css" />

    <!-- font awesome cdn link  -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">
    <%--  --%>
    <!-- custom css file link  -->
    <link rel="stylesheet" href="style.css">

</head>
<body>
    
<!-- header section starts  -->

<header class="header">

    <a href="#" class="logo"> <i class="fas fa-shopping-basket"></i> OnlineGrocer </a>

    <nav class="navbar">
        <a href="#home">home</a>
        <a href="#features">features</a>
        <a href="#products">products</a>
        <a href="#categories">categories</a>
        <a href="ContactMain.aspx">feedback</a>
        <!-- <a href="#feedback">feedback</a> -->
        <!-- <a href="#blogs">blogs</a> -->
    </nav>

    <div class="icons">
        <div class="fas fa-bars" id="menu-btn"></div>
        <div class="fas fa-search" id="search-btn"></div>
       <div class="fas fa-shopping-cart" id="cart-btn"></div>
        <div class="fas fa-user" id="login-btn"></div>
      
    </div>

    <form action="" class="search-form">
        <input type="search" id="search-box" placeholder="search here...">
        <label for="search-box" class="fas fa-search"></label>
    </form>
    <!--
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
        -->
    <form action="" class="login-form" runat=server>
        <h3>login now</h3>
        <asp:TextBox ID="txtemail" class="box" runat="server" placeholder="Your User name / Email ID"></asp:TextBox>
        <asp:TextBox ID="txtpassword" class="box" runat="server" 
            ontextchanged="txtpassword_TextChanged"  placeholder="Your Passwors"></asp:TextBox>
      <!--  <input type="email" placeholder="your email" class="box">
        <input type="password" placeholder="your password" class="box">-->
        <!-- <p>forget your password <a href="#">click here</a></p> -->
        <p>don't have an account <a href="Registration.aspx">create now</a></p>
       <!-- <input type="submit" value="login now" class="btn">-->
        <asp:Button ID="txtLogin" runat="server" Text="login now" class="btn" 
            onclick="txtLogin_Click"></asp:Button>
    </form>

</header>

<!-- header section ends -->

<!-- home section starts  -->

<section class="home" id="home">

    <div class="content">
        <h3>fresh and <span>organic</span> products for your</h3>
        <!-- <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Aliquam libero nostrum veniam facere tempore nisi.</p> -->
        <a href="Registration.aspx" class="btn">Register</a>
    </div>

</section>

<!-- home section ends -->





<section class="features" id="features">
    <div><div class="slideshow-container">

        <div class="mySlides fade">
          <div class="numbertext">1 / 3</div>
          <img src="image/fruitss.jpg" style="width:100%">
          <div class="text">Caption Text</div>
        </div>
        
        <div class="mySlides fade">
          <div class="numbertext">2 / 3</div>
          <img src="image/vegitabless.jpg" style="width:100%">
          <div class="text">Caption Two</div>
        </div>
        
        <div class="mySlides fade">
          <div class="numbertext">3 / 3</div>
          <img src="image/dryfruitss.png" style="width:100%">
          <div class="text">Caption Three</div>
        </div>
        
        <a class="prev" onclick="plusSlides(-1)">❮</a>
        <a class="next" onclick="plusSlides(1)">❯</a>
        
        </div>
        <br>
        
        <div style="text-align:center">
          <span class="dot" onclick="currentSlide(1)"></span> 
          <span class="dot" onclick="currentSlide(2)"></span> 
          <span class="dot" onclick="currentSlide(3)"></span> 
        </div>

        <!-- features section starts  -->


    <h1 class="heading"> our <span>features</span> </h1>

    <div class="box-container">


        <div class="box">
            <img src="image/feature-img-3.png" alt="">
            <h3>easy payment<h3>
            <a href="#"class="btn">payment</a>
            </div>
            
        </section>
        


<!-- features section ends -->

<!-- products section starts  -->

<section class="products" id="products">

    <h1 class="heading"> our <span>products</span> </h1>

    <div class="swiper product-slider">

        <div class="swiper-wrapper">

            <div class="swiper-slide box">
                <img src="image/product-1.png" alt="">
                <h3>fresh orange</h3>
                <div class="price"> 500g Rs201/- </div> -->
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <a href="#" class="btn">add to cart</a>
            </div>

            <div class="swiper-slide box">
                <img src="image/product-2.png" alt="">
                <h3>fresh onion</h3>
                <div class="price"> 500g Rs25/-</div> -->
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <a href="#" class="btn">add to cart</a>
            </div>

            <div class="swiper-slide box">
                <img src="image/almond.png" alt="">
                <h3>almond</h3>
                <div class="price"> Rs 299/- </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <a href="#" class="btn">add to cart</a>
            </div>

            <div class="swiper-slide box">
                <img src="image/product-4.png" alt="">
                <h3>fresh cabbage</h3>
                <div class="price"> 1Pc Rs27/-</div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <a href="#" class="btn">add to cart</a>
            </div>

        </div>

    </div>

    <div class="swiper product-slider">

        <div class="swiper-wrapper">

            <div class="swiper-slide box">
                <img src="image/appricot.png" alt="">
                <h3>apricot</h3>
                <div class="price"> Rs 899/- </div> 
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <a href="#" class="btn">add to cart</a>
            </div>

            <div class="swiper-slide box">
                <img src="image/product-6.png" alt="">
                <h3>fresh avocado</h3>
                <div class="price"> 1 Pc Rs266/-</div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <a href="#" class="btn">add to cart</a>
            </div>

            <div class="swiper-slide box">
                <img src="image/toor dal.png" alt="">
                <h3>toor dal</h3>
                <div class="price"> 500g Rs105/- </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <a href="#" class="btn">add to cart</a>
            </div>

            <div class="swiper-slide box">
                <img src="image/masoor.png" alt="">
                <h3>masoor dal</h3>
                <div class="price"> 500g Rs80/- </div>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star-half-alt"></i>
                </div>
                <a href="#" class="btn">add to cart</a>
            </div>

        </div>

    </div>


</section>

<!-- products section ends -->

<!-- categories section starts  -->

<section class="categories" id="categories">

    <h1 class="heading"> product <span>categories</span> </h1>

    <div class="box-container">

        <div class="box">
            <img src="image/cat-2.png" alt="">
            <h3>vegitables</h3>
            <p>upto 45% off</p>
            <a href="vegitables.html" class="btn">shop now</a>
        </div>

        <div class="box">
            <img src="image/cat-1.png" alt="">
            <h3>fresh fruits</h3>
            <p>upto 45% off</p>
            <a href="fruits.html" class="btn">shop now</a>
        </div>

        <div class="box">
            <img src="image/DryFruit.png" alt="">
            <h3>dry fruits</h3>
            <p>upto 45% off</p>
            <a href="dryfruits.html" class="btn">shop now</a>
        </div>

        <div class="box">
            <img src="image/PULSES.png" alt="">
            <h3>pulses</h3>
            <p>upto 45% off</p>
            <a href="pulses.html" class="btn">shop now</a>
        </div>

    </div>

</section>










 





<script src="https://unpkg.com/swiper@7/swiper-bundle.min.js"></script>

<!-- custom js file link  -->
<script src="script.js"></script>

</body>
</html>
