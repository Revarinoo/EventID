<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="Promotion.aspx.cs" Inherits="EventID.View.Promotion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="promotion.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="op3" style="margin-top:-50px">
        <div class="backgroundPromotion">
            <div class=" container-fluid mt-5">
                <div id="myCarousel" class="carousel slide" data-ride="carousel">
                    <div class="carousel-inner row w-100 mx-auto">
                        <div class="carousel-item col-md-3 active txtCategory">
                            <div class="card">
                                <a href="./Promotion.aspx">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/all.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center ">All Category</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./Promotion.aspx?id=1&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/museum.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Venue</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./Promotion.aspx?id=2&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/buffet.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Catering</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./Promotion.aspx?id=3&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/balloons.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Decoration</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./Promotion.aspx?id=4&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/karaoke.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">MC</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./Promotion.aspx?id=5&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/band.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Musician</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./Promotion.aspx?id=6&subcat=0">
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
    <br />
    <div class="container-fluid">
        <div class="backgroundPromotion2">
            <div>
            <asp:Label ID="lblPromo" runat="server" Text="All Category" Font-Bold="True" ForeColor="White" Font-Size="X-Large" Style="float: left; margin: 10px auto auto 25px;"></asp:Label><br />
            <br />
            <br />
        </div>
            <asp:Repeater ID="repeaterPromotion" runat="server">
                <ItemTemplate>
                    <a href="./ViewProduct.aspx?ID=<%#Eval("ProductID") %>">
                        <div class="card PositionDisp" style="width: 18rem;">
                            <img src="./Assets/<%#Eval("ImageName") %>" alt="Private Beach Picture" class="cobabanner customPhoto" />
                            <div class="card-body">
                                <h5 class="card-subtitle mb-2 text-muted"><%#Eval("ProductName") %></h5>
                                <p style="color: #e87d1b; text-decoration: line-through;">Rp<%#Eval("Price") %></p>
                                <p class="card-text">Rp<%#Eval("newPrice") %></p>
                            </div>
                        </div>
                    </a>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <br />
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
