<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="EventID.View.ViewProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="ViewProduct.css">
    <link rel="stylesheet" type="text/css" href="home1.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="view cf">
        <div class="slideshow-container" style="box-sizing: border-box; float: left; width: 60%;">
            <asp:Repeater ID="rptrProductImages" runat="server">
                <ItemTemplate>
                    <div class="mySlides">
                        <a href="#">
                            <img id="hgh" src="./Assets/<%# Eval("ImageName") %>" style="margin-left: 12%; width: 80%;"></a>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <div style="margin-left: 50%;">
                <span class="dot" onclick="currentSlide(1)"></span>
                <span class="dot" onclick="currentSlide(2)"></span>
            </div>

            <a class="prev" onclick="plusSlides(-1)" style="left: 12%">&#10094;</a>
            <a class="next" onclick="plusSlides(1)" style="right: 8%;">&#10095;</a>
        </div>

        <asp:Repeater ID="rptrProducts" runat="server">
            <ItemTemplate>
                <h4 style="text-align: center; margin-right: 6%; margin-top: 30px; margin-bottom: -30px;"><%# Eval("ProductName") %></h4>
                <div class="info">
                    <h6 class="pc">Price</h6>
                    <h6 class="number">Rp. <%# Eval("Price") %></h6>
                    <hr style="width: 90%; text-align: center; border-color: #F3C963;" />
                    <h6 class="pc">Capacity</h6>
                    <h6 class="number" style="margin-bottom: 10px;">100 Pax</h6>
                </div>
                <div class="btnProduct">
                    <asp:Button ID="btnCart" Text="Add to Cart" runat="server" class="btn btn-primary btnCart" OnClick="btnCart_Click" />
                    <asp:Button ID="btnOrder" Text="Order Now" runat="server" class="btn btn-primary btnOrder" OnClick="btnCart_Click" />
                </div>
                <div class="btnProduct" style="margin-left: 205px;">
                    <asp:Button ID="btnChat" Text="Chat" runat="server" class="btn btn-primary chat" />
                </div>
                </div>

            <div class="information cf">
                <div class="description">
                    <h5 style="margin-left: 95px;">Description</h5>
                    <p><%# Eval("Description") %></p>
                    <p style="margin-left: 115px;">
                        - Private venue until 10.00 pm<br />
                        - Complimentary of 2 tiers wedding cake<br />
                        - Standard sound system<br />
                        - Exclusive usage of The Pavilion or Rooftop Garden with stylish decoration & table set up<br />
                        - One-night stay in a Deluxe Lagoon Access Room, including breakfast for two<br />
                        - Selection of 4 canapé upon arrival<br />
                        - Set menu dinner or array of signature East Meet West buffet dinner<br />
                        - Signature mocktail & fresh cold towel upon arrival<br />
                        - Two-hours free flow selection of soft drinks and juices during the dinner<br />
                        - Beverages : water, softdrinks, juice<br />
                        - Contemporary of fire dance accompaniment
                    </p>
                </div>
                <div class="maps">
                    <h5>Location : Bali, Indonesia.</h5>
                    <p>Private Beach</p>
                    <p>Jl. Private No. Secret</p>
                    <a href="https://goo.gl/maps/DTap4Je7kMNRaurr6" target="_blank">
                        <div class="btnMaps">
                            <h6>Open in GoogleMap</h6>
                        </div>
                    </a>
                </div>
            </div>
            </ItemTemplate>
        </asp:Repeater>
        <script>
            var slideIndex = 1;
            showSlides(slideIndex);

            // Next/previous controls
            function plusSlides(n) {
                showSlides(slideIndex += n);
            }

            // Thumbnail image controls
            function currentSlide(n) {
                showSlides(slideIndex = n);
            }

            function showSlides(n) {
                var i;
                var slides = document.getElementsByClassName("mySlides");
                var dots = document.getElementsByClassName("dot");
                if (n > slides.length) { slideIndex = 1 }
                if (n < 1) { slideIndex = slides.length }
                for (i = 0; i < slides.length; i++) {
                    slides[i].style.display = "none";
                }
                for (i = 0; i < dots.length; i++) {
                    dots[i].className = dots[i].className.replace(" active", "");
                }
                slides[slideIndex - 1].style.display = "block";
                dots[slideIndex - 1].className += " active";
            }
        </script>
</asp:Content>
