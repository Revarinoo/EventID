<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EventID.View.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="home.css">
    <link rel="stylesheet" type="text/css" href="1.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <div class="filter">
        <input class="form-control mr-sm-2 search2" type="search" placeholder="Location" aria-label="Search">
        <button id="dropdown" class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Category Type </button>
        <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
            <a class="dropdown-item" href="#">Venue</a>
            <a class="dropdown-item" href="#">Cathering</a>
            <a class="dropdown-item" href="#">MC</a>
        </div>
        <button class="btn  my-2 my-sm-0" id="btnSearch" type="submit">Search</button>
    </div>
    <br>
    <div class="intro">
        <p id="title1">Introduction E-vent.id</p>
        <p id="text1">E-vent.id adalah platform pemesanan kebutuhan event dengan harga terjangkau. Disini kami memberikan kemudahan, memilih, dan memesan venue, cathering, decoration, dan masih banyak lagi.</p>
    </div>
    <br>

    <div class="op container-fluid">
        <h2 class="text-center mb-3 title2">Recommended Products</h2>
        <br>
        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <div class="carousel-inner row w-100 mx-auto">
                <div class="carousel-item col-md-4 active">
                    <div class="card">
                        <h4 class="card-title text-center">Venue</h4>
                        <asp:Image class="card-img-top img-fluid customPosition" ID="Image1" runat="server" />
                        <div class="card-body">
                            <h5 class="card-subtitle mb-2 text-muted text-center">
                                <asp:Label ID="Label1" Text="Label" runat="server" /></h5>
                            <a href="./ViewProduct.aspx?ID=44250" class="btn btn-warning">Order Now</a>
                        </div>
                    </div>
                </div>
                <div class="carousel-item col-md-4">
                    <div class="card">
                        <h4 class="card-title text-center">Cathering</h4>
                        <asp:Image class="card-img-top img-fluid customPosition" ID="Image2" runat="server" />
                        <div class="card-body">
                            <h5 class="card-subtitle mb-2 text-muted text-center">
                                <asp:Label ID="Label2" Text="Label" runat="server" /></h5>
                            <a href="./ViewProduct.aspx?ID=44252" class="btn btn-warning">Order Now</a>
                        </div>
                    </div>
                </div>
                <div class="carousel-item col-md-4">
                    <div class="card">
                        <h4 class="card-title text-center">Decoration</h4>
                        <asp:Image class="card-img-top img-fluid customPosition" ID="Image3" runat="server" />
                        <div class="card-body">
                            <h5 class="card-subtitle mb-2 text-muted text-center">
                                <asp:Label ID="Label3" Text="Label" runat="server" /></h5>
                            <a href="./ViewProduct.aspx?ID=44255" class="btn btn-warning">Order Now</a>
                        </div>
                    </div>
                </div>
                <div class="carousel-item col-md-4">
                    <div class="card">
                        <h4 class="card-title text-center">MC</h4>
                        <asp:Image class="card-img-top img-fluid customPosition" ID="Image4" runat="server" />
                        <div class="card-body">
                            <h5 class="card-subtitle mb-2 text-muted text-center">
                                <asp:Label ID="Label4" Text="Label" runat="server" /></h5>
                            <a href="./ViewProduct.aspx?ID=44256" class="btn btn-warning">Order Now</a>
                        </div>
                    </div>
                </div>
                <div class="carousel-item col-md-4">
                    <div class="card">
                        <h4 class="card-title text-center">Musician</h4>
                        <asp:Image class="card-img-top img-fluid customPosition" ID="Image5" runat="server" />
                        <div class="card-body">
                            <h5 class="card-subtitle mb-2 text-muted text-center">
                                <asp:Label ID="Label5" Text="Label" runat="server" /></h5>
                            <a href="./ViewProduct.aspx?ID=44257" class="btn btn-warning">Order Now</a>
                        </div>
                    </div>
                </div>
                <div class="carousel-item col-md-4">
                    <div class="card">
                        <h4 class="card-title text-center ">Photography</h4>
                        <asp:Image class="card-img-top img-fluid customPosition" ID="Image6" runat="server" />
                        <div class="card-body">
                            <h5 class="card-subtitle mb-2 text-muted text-center">
                                <asp:Label ID="Label6" Text="Label" runat="server" /></h5>
                            <a href="./ViewProduct.aspx?ID=44258" class="btn btn-warning">Order Now</a>
                        </div>
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

    <br>
    <br>
    <br>
    <br>
    <br>
    <div class="op2 container-fluid" style="display: block;">
        <h2 class="text-center mb-3 title3">Favourite Product</h2>
        <div class="border2">
            <div class="carousel-inner row w-100 mx-auto">
                <div class="carousel-item col-md-4 active">
                    <div class="card">
                        <h4 class="card-title text-center">Venue</h4>
                        <img class="card-img-top img-fluid customPosition" src="./Assets/2.jpg" alt="Card image cap">
                        <div class="card-body">
                            <a href="./ViewProduct.aspx?ID=44255" class="btn btn-warning">Order Now</a>
                        </div>
                    </div>
                </div>
                <div class="carousel-item col-md-4">
                    <div class="card">
                        <h4 class="card-title text-center">Cathering</h4>
                        <img class="card-img-top img-fluid customPosition" src="./Assets/4.jpg" alt="Card image cap">
                        <div class="card-body">
                            <a href="./ViewProduct.aspx?ID=44252" class="btn btn-warning">Order Now</a>
                        </div>
                    </div>
                </div>
                <div class="carousel-item col-md-4">
                    <div class="card">
                        <h4 class="card-title text-center">Decoration</h4>
                        <img class="card-img-top img-fluid customPosition" src="./Assets/6.jpg" alt="Card image cap">
                        <div class="card-body">
                            <a href="./ViewProduct.aspx?ID=44258" class="btn btn-warning">Order Now</a>
                            <%--<asp:Button class="btn btn-warning" Text="Order Now" runat="server" />--%>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <br>
    <br>
    <br>
    <br>

    <script src="https://code.jquery.com/jquery-1.12.4.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#myCarousel").on("slide.bs.carousel", function (e) {
                var $e = $(e.relatedTarget);
                var idx = $e.index();
                var itemsPerSlide = 3;
                var totalItems = $(".op .carousel-item").length;

                if (idx >= totalItems - (itemsPerSlide - 1)) {
                    var it = itemsPerSlide - (totalItems - idx);
                    for (var i = 0; i < it; i++) {
                        // append slides to end
                        if (e.direction == "left") {
                            $(".op .carousel-item")
                              .eq(i)
                              .appendTo(".op .carousel-inner");
                        } else {
                            $(".op .carousel-item")
                              .eq(0)
                              .appendTo($(this).find(".carousel-inner"));
                        }
                    }
                }
            });
        });

    </script>
</asp:Content>
