﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="Planner-Catering.aspx.cs" Inherits="EventID.View.Planner_Catering" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Planner.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="planner-container">
        <h1>Planner</h1>
        <div class="category">
            <div class="box-category">
                <h5>Venue</h5>
                <img alt="centang" src="./Assets/cek1.svg" class="cek" />
            </div>
            <div class="box-category">
                <h5>Cathering</h5>
                <img alt="centang" src="./Assets/cek1.svg" class="cek" />
            </div>
            <div class="box-category">
                <h5>Decoration</h5>
                <img alt="centang" src="./Assets/cek2.svg" class="cek" />
            </div>
            <div class="box-category">
                <h5>MC</h5>
                <img alt="centang" src="./Assets/cek2.svg" class="cek" />
            </div>
            <div class="box-category">
                <h5>Musician</h5>
                <img alt="centang" src="./Assets/cek2.svg" class="cek" />
            </div>
            <div class="box-category">
                <h5>Photography</h5>
                <img alt="centang" src="./Assets/cek2.svg" class="cek" />
            </div>
        </div>
    </div>

    <div class="venue">
        <div class="venue-container cf">
            <h4>Cathering</h4>
            <div class="choose">
                <asp:Button ID="BtnAll" Text="All" runat="server" class="btn btn-primary btnLoginBackground" OnClick="BtnAll_Click" />
                <asp:Button ID="BtnBuffet" Text="Buffet" runat="server" class="btn btn-primary btnLoginBackground" OnClick="BtnBuffet_Click" />
                <asp:Button ID="BtnFD" Text="Food Corner & Dessert Table" runat="server" class="btn btn-primary btnLoginBackground" OnClick="BtnFD_Click" />
                <asp:Button ID="BtnDB" Text="Drink & Beverage" runat="server" class="btn btn-primary btnLoginBackground" OnClick="BtnDB_Click" />
                <asp:Button ID="BtnCake" Text="Cake" runat="server" class="btn btn-primary btnLoginBackground" OnClick="BtnCake_Click" />
            </div>
            <div class="row">
                <asp:Repeater ID="rptrProducts" runat="server">
                    <ItemTemplate>
                        <div class="col-sm-3 col-md-3">
                            <a href="">
                                <div class="venue-box">
                                    <img src="./Assets/<%# Eval("ImageName") %>" class="image" />
                                    <h6><%# Eval("ProductName") %></h6>
                                    <h6 class="price">Rp. <%# Eval("Price") %></h6>
                                </div>
                            </a>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="btnVenue cf">
                <asp:Button ID="btnNeed" Text="I don't need this" runat="server" class="btn btn-primary btnRegisBackground" OnClick="btnNeed_Click" />
                <asp:Button ID="btnNext" Text="Next" runat="server" class="btn btn-primary btnLoginBackground" OnClick="btnNext_Click" />
            </div>
        </div>
    </div>


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
