<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="AllProduct.aspx.cs" Inherits="EventID.View.AllProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="product.css" />
    <link rel="stylesheet" type="text/css" href="AllProduct.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="op3" style="margin-top:-50px;">
        <div class="backgroundProduct">
            <div class=" container-fluid mt-5">
                <div id="myCarousel" class="carousel slide" data-ride="carousel">
                    <div class="carousel-inner row w-100 mx-auto">
                        <div class="carousel-item col-md-3 active txtCategory">
                            <div class="card">
                                <a href="./AllProduct.aspx?id=7&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/all.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center ">All Category</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./AllProduct.aspx?id=1&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/museum.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Venue</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./AllProduct.aspx?id=2&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/buffet.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Catering</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./AllProduct.aspx?id=3&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/balloons.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Decoration</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./AllProduct.aspx?id=4&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/karaoke.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">MC</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./AllProduct.aspx?id=5&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/band.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Musician</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./AllProduct.aspx?id=6&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/camera.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Photography</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                    <a class="carousel-control-prev btnPrevNext" href="#myCarousel" role="button" data-slide="prev">
                        <i class="fas fa-backward"></i>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="carousel-control-next btnPrevNext" href="#myCarousel" role="button" data-slide="next">
                        <i class="fas fa-forward"></i>
                        <span class="sr-only">Next</span>
                    </a>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />

    <!-- CODE MATI GK ADA EFEK APA APA-->
    <div class="container-fluid backgroundProduct1">
        <h1 class="card-subtitle judul">
            <asp:Label ID="LblClick" class="pst" Text="label" Visible="false" runat="server" />
        </h1>
        <asp:Repeater ID="repeaterClick" runat="server">
            <ItemTemplate>
                <a href="./ViewProduct.aspx">
                    <div class="row" style="display: inline-block; margin-left: 20px;">
                        <div class="col-sm-3 col-md-3">
                            <div class="thumbnail">
                                <img src="./Assets/<%#Eval("ImageName") %>" alt="Private Beach Picture" class="cobabanner" />
                                <div class="captions">
                                    <h5><%#Eval("ProductName") %></h5>
                                    <p>Rp<%#Eval("Price") %></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </ItemTemplate>
        </asp:Repeater>

    </div>
    <!-- CODE MATI GK ADA EFEK APA APA -->

    <br />
    <br />
    <div class="container-fluid backgroundProduct1">
        <h1 class="card-subtitle judul">
            <asp:Label ID="LblVenue" class="pst" Text="label" Visible="true" runat="server" />
        </h1>
        <asp:Repeater ID="repeaterVenue" Visible="true" runat="server">
            <ItemTemplate>
                <a href="./ViewProduct.aspx">
                    <div class="row" style="display: inline-block; margin-left: 20px;">
                        <div class="col-sm-3 col-md-3">
                            <div class="thumbnail">
                                <img src="./Assets/<%#Eval("ImageName") %>" alt="Private Beach Picture" class="cobabanner" />
                                <div class="captions">
                                    <h5><%#Eval("ProductName") %></h5>
                                    <p>Rp<%#Eval("Price") %></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </ItemTemplate>
        </asp:Repeater>
        <div align="center">
            <asp:Button Text="See More" ID="SeeMoreVBtn" class="button" Style="vertical-align: middle" Visible="true" runat="server" OnClick="btnSeeMore_Click" />
        </div>
    </div>
    <br />
    <br />
    <div class="container-fluid backgroundProduct1">
        <h1 class="card-subtitle judul">
            <asp:Label ID="LblCatering" class="pst" Text="label" Visible="true" runat="server" />
        </h1>
        <asp:Repeater ID="repeaterCatering" Visible="true" runat="server">
            <ItemTemplate>
                <a href="./ViewProduct.aspx">
                    <div class="row" style="display: inline-block; margin-left: 20px;">
                        <div class="col-sm-3 col-md-3">
                            <div class="thumbnail">
                                <img src="./Assets/<%#Eval("ImageName") %>" alt="Private Beach Picture" class="cobabanner" />
                                <div class="captions">
                                    <h5><%#Eval("ProductName") %></h5>
                                    <p>Rp<%#Eval("Price") %></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </ItemTemplate>
        </asp:Repeater>
        <div align="center">
            <asp:Button Text="See More" ID="SeeMoreCBtn" class="button" Style="vertical-align: middle" Visible="true" runat="server" OnClick="btnSeeMore_Click" />
        </div>
    </div>
    <br />
    <br />
    <div class="container-fluid backgroundProduct1">
        <h1 class="card-subtitle judul">
            <asp:Label ID="LblDecoration" class="pst" Text="label" Visible="true" runat="server" />
        </h1>
        <asp:Repeater ID="repeaterDecoration" Visible="true" runat="server">
            <ItemTemplate>
                <a href="./ViewProduct.aspx">
                    <div class="row" style="display: inline-block; margin-left: 20px;">
                        <div class="col-sm-3 col-md-3">
                            <div class="thumbnail">
                                <img src="./Assets/<%#Eval("ImageName") %>" alt="Private Beach Picture" class="cobabanner" />
                                <div class="captions">
                                    <h5><%#Eval("ProductName") %></h5>
                                    <p>Rp<%#Eval("Price") %></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </ItemTemplate>
        </asp:Repeater>
        <div align="center">
            <asp:Button Text="See More" ID="SeeMoreDBtn" class="button" Style="vertical-align: middle" Visible="true" runat="server" OnClick="btnSeeMore_Click" />
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-1.12.4.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script>
        $(document).ready(function () {
            $(".op3 #myCarousel").on(".op3 slide.bs.carousel", function (e) {
                var $e = $(e.relatedTarget);
                var idx = $e.index();
                var itemsPerSlide = 4;
                var totalItems = $(".op3 .carousel-item").length;

                if (idx >= totalItems - (itemsPerSlide - 1)) {
                    var it = itemsPerSlide - (totalItems - idx);
                    for (var i = 0; i < it; i++) {
                        // append slides to end
                        if (e.direction == "left") {
                            $(".op3 .carousel-item")
                              .eq(i)
                              .appendTo(".op3 .carousel-inner");
                        } else {
                            $(".op3 .carousel-item")
                              .eq(0)
                              .appendTo($(this).find(" .carousel-inner"));
                        }
                    }
                }
            });
        });

    </script>
</asp:Content>
