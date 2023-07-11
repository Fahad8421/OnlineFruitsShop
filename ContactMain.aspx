<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactMain.aspx.cs" Inherits="ContactMain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
        
        <!-- SEO Meta Tags -->
        <meta name="description" content="Aria is a business focused HTML landing page template built with Bootstrap to help you create lead generation websites for companies and their services.">
        <meta name="author" content="Inovatik">
    
        <!-- OG Meta Tags to improve the way the post looks when you share the page on LinkedIn, Facebook, Google+ -->
        <meta property="og:site_name" content="" /> <!-- website name -->
        <meta property="og:site" content="" /> <!-- website link -->
        <meta property="og:title" content=""/> <!-- title shown in the actual shared post -->
        <meta property="og:description" content="" /> <!-- description shown in the actual shared post -->
        <meta property="og:image" content="" /> <!-- image link, make sure it's jpg -->
        <meta property="og:url" content="" /> <!-- where do you want your post to link to -->
        <meta property="og:type" content="article" />
    
        <!-- Website Title -->
        <title>Aria - Business HTML Landing Page Template</title>
        
        <!-- Styles -->
        <link href="https://fonts.googleapis.com/css?family=Montserrat:500,700&display=swap&subset=latin-ext" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Open+Sans:400,400i,600&display=swap&subset=latin-ext" rel="stylesheet">
        <link href="css/bootstrap.css" rel="stylesheet">
        <link href="css/fontawesome-all.css" rel="stylesheet">
        <link href="css/swiper.css" rel="stylesheet">
        <link href="css/magnific-popup.css" rel="stylesheet">
        <link href="css/styles.css" rel="stylesheet">
        
        <!-- Favicon  -->
        <link rel="icon" href="images/download (1).jpg">
</head>
<body>
     <div id="contact" class="form-2">
            <div class="container">
                <div class="row">
                    <div class="col-lg-6">
                        <div class="text-container">
                            <div class="section-title">CONTACT</div>
                            <h2>Get In Touch Using The Form</h2>
                            <p>You can do election of every type also any think problem occess,So Contact me!</p>
                            <ul class="list-unstyled li-space-lg">
                                <li class="address"><i class="fas fa-map-marker-alt"></i>240/5,South Kasba,Datta Chowk,Solapur-413007</li>
                                <li><i class="fas fa-phone"></i><a href="#">+91 7083836156</a></li>
                               <!-- <li><i class="fas fa-phone"></i><a href="tel:003024630820">+81 720 22 128</a></li>-->
                                <li><i class="fas fa-envelope"></i><a href="#">imranmurshad16@gmail.com.com</a></li>
                            </ul>
                            <h3>Follow Online Fruit Shop System</h3>
    
                            <span class="fa-stack">
                                <a href="#your-link">
                                    <span class="hexagon"></span>
                                    <i class="fab fa-facebook-f fa-stack-1x"></i>
                                </a>
                            </span>
                            <span class="fa-stack">
                                <a href="#your-link">
                                    <span class="hexagon"></span>
                                    <i class="fab fa-twitter fa-stack-1x"></i>
                                </a>
                            </span>
                            <span class="fa-stack">
                                <a href="#your-link">
                                    <span class="hexagon"></span>
                                    <i class="fab fa-pinterest fa-stack-1x"></i>
                                </a>
                            </span>
                            <span class="fa-stack">
                                <a href="#your-link">
                                    <span class="hexagon"></span>
                                    <i class="fab fa-instagram fa-stack-1x"></i>
                                </a>
                            </span>
                            <span class="fa-stack">
                                <a href="#your-link">
                                    <span class="hexagon"></span>
                                    <i class="fab fa-linkedin-in fa-stack-1x"></i>
                                </a>
                            </span>
                            <span class="fa-stack">
                                <a href="#your-link">
                                    <span class="hexagon"></span>
                                    <i class="fab fa-behance fa-stack-1x"></i>
                                </a>
                            </span>
                        </div> <!-- end of text-container -->
                    </div> <!-- end of col -->
                    <div class="col-lg-6">
                        
                        <!-- Contact Form -->
                        <form id="contactForm" data-toggle="validator" data-focus="false" runat="server">
                            <!--<div class="form-group">
                                <input type="text" class="form-control-input" id="cname" required name="cname">
                                <label class="label-control" for="cname">Name</label>
                                <div class="help-block with-errors"></div>
                            </div>-->
                            <div class="form-group" >
                        <asp:TextBox ID="txtname" runat="server" class="form-control-input"></asp:TextBox>
                        
                                <asp:Label ID="Label1" runat="server" Text="Name" class="label-control" for="cname"></asp:Label>
                                <div class="help-block with-errors"></div>
                        
                        </div>
                           <!-- <div class="form-group">
                                <input type="email" class="form-control-input" id="cemail" required name="cemail">
                                <label class="label-control" for="cemail">Email</label>
                                <div class="help-block with-errors"></div>
                            </div>-->
                            <div class="form-group">
                                <asp:TextBox ID="txtemail" runat="server" class="form-control-input" required name="cemail"></asp:TextBox>
                                <asp:Label ID="Label2" runat="server" Text="Email ID" class="label-control" for="cemail"></asp:Label>
                                <div class="help-block with-errors"></div>
                            </div>
                           <!-- <div class="form-group">
                                <textarea class="form-control-textarea" id="cmessage" required name="cmessage"></textarea>
                                <label class="label-control" for="cmessage">Your message</label>
                                <div class="help-block with-errors"></div>
                            </div>-->
                            <div class="form-group">
                                <asp:TextBox ID="txtmsg" runat="server" class="form-control-textarea" required name="cmessage"></asp:TextBox>
                                <asp:Label ID="Label3" runat="server" Text="Your Message" class="label-control" for="cmessage"></asp:Label>
                                <div class="help-block with-errors"></div>
                            </div>
                            <!--<div class="form-group checkbox">
                                <input type="checkbox" id="cterms" value="Agreed-to-Terms" required>I agree with Aria's stated <a href="privacy-policy.html">Privacy Policy</a> and <a href="terms-conditions.html">Terms Conditions</a> 
                                <div class="help-block with-errors"></div>
                            </div>-->
                          <!--  <div class="form-group">
                                <button type="submit" class="form-control-submit-button">SUBMIT MESSAGE</button>
                            </div>-->
                            <div class="form-group">
                                <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT MESSAGE" 
                                    class="form-control-submit-button" onclick="btnSubmit_Click"/>
                            </div>
                          
                            
                            <div class="form-group">
                           <center>     <a href="IndexPage.aspx" class="form-control-submit-button">BACK TO HOME PAGE</a></center>
                            </div>
                            <div class="form-message">
                                <div id="cmsgSubmit" class="h3 text-center hidden"></div>
                            </div>
                        </form>
                        <!-- end of contact form -->
    
                    </div> <!-- end of col -->
                </div> <!-- end of row -->
            </div> <!-- end of container -->
        </div> <!-- end of form-2 -->
        <!-- end of contact -->
</body>
</html>
