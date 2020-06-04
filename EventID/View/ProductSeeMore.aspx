<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="ProductSeeMore.aspx.cs" Inherits="EventID.View.ProductSeeMore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="custom-css.css" />
    <link rel="stylesheet" type="text/css" href="productseemore.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- image-card carousel-->
    <div class="op3">
        <div class="backgroundPromotion">
            <div class=" container-fluid mt-5">
                <div id="myCarousel" class="carousel slide" data-ride="carousel">
                    <div class="carousel-inner row w-100 mx-auto">
                        <div class="carousel-item col-md-3 active txtCategory">
                            <div class="card">
                                <a href="./ProductSeeMore.aspx">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/all.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center ">All Category</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./ProductSeeMore.aspx?id=1&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/museum.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Venue</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./ProductSeeMore.aspx?id=2&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/buffet.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Catering</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./ProductSeeMore.aspx?id=3&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/balloons.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Decoration</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./ProductSeeMore.aspx?id=4&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/karaoke.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">MC</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./ProductSeeMore.aspx?id=5&subcat=0">
                                    <img class="card-img-top img-fluid customPosition2" src="./Assets/band.svg" alt="Card image cap">
                                    <div class="card-body">
                                        <h4 class="card-title text-center">Musician</h4>
                                    </div>
                                </a>
                            </div>
                        </div>
                        <div class="carousel-item col-md-3 txtCategory">
                            <div class="card">
                                <a href="./ProductSeeMore.aspx?id=6&subcat=0">
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
    <!-- image-card carousel-->

    <!--isi product see more-->
    <div class="container-fluid seemorecard">
        <div>
            <asp:Label ID="SeeMoreCardTitle" runat="server" Text="All Category" Font-Bold="True" ForeColor="White" Font-Size="X-Large" Style="float: left; margin: 10px auto auto 25px;"></asp:Label><br />
            <br />
            <br />
        </div>
        <div class="row" style="margin: -15px auto auto 15px">
            <asp:Button ID="SeeMoreCardBtnAll" runat="server" Text="All" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnAll_Click" />
            <asp:Button ID="SeeMoreCardBtnBallroom" runat="server" Text="Ballroom" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnBallroom_Click" />
            <asp:Button ID="SeeMoreCardBtnHotel" runat="server" Text="Hotel & Resort" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnHotel_Click" />
            <asp:Button ID="SeeMoreCardBtnHall" runat="server" Text="Function Hall" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnHall_Click" />
            <asp:Button ID="SeeMoreCardBtnResto" runat="server" Text="Restaurant & Cafe" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnResto_Click" />
            <asp:Button ID="SeeMoreCardBtnIdn" runat="server" Text="Indonesian food" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnIdn_Click" />
            <asp:Button ID="SeeMoreCardBtnWstr" runat="server" Text="Western food" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnWstr_Click"/>
            <asp:Button ID="SeeMoreCardBtnChi" runat="server" Text="Chinese food" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnChi_Click"/>
            <asp:Button ID="SeeMoreCardBtnIta" runat="server" Text="Italian food" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnIta_Click"/>
            <asp:Button ID="SeeMoreCardBtnBday" runat="server" Text="Birthday" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnBday_Click"/>
            <asp:Button ID="SeeMoreCardBtnEvent" runat="server" Text="Wedding" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnEvent_Click"/>
            <asp:Button ID="SeeMoreCardBtnProm" runat="server" Text="Prom" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnProm_Click"/>
            <asp:Button ID="SeeMoreCardBtnConcert" runat="server" Text="Concert" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnConcert_Click"/>
            <asp:Button ID="SeeMoreCardBtnSeminar" runat="server" Text="Seminar" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnSeminar_Click"/>
            <asp:Button ID="SeeMoreCardBtnSMC" runat="server" Text="Single MC" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnSMC_Click"/>
            <asp:Button ID="SeeMoreCardBtnDMC" runat="server" Text="Duo MC" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnDMC_Click"/>
            <asp:Button ID="SeeMoreCardBtnGMC" runat="server" Text="Group MC" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnGMC_Click"/>
            <asp:Button ID="SeeMoreCardBtnSolo" runat="server" Text="Soloist" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnSolo_Click"/>
            <asp:Button ID="SeeMoreCardBtnGroup" runat="server" Text="Music Group" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnGroup_Click"/>
            <asp:Button ID="SeeMoreCardBtnBand" runat="server" Text="Band" CssClass="btn btn-primary btnLoginBackground" OnClick="SeeMoreCardBtnBand_Click"/>  
        </div>
        <div style="margin-left: 30px;">
            <asp:Repeater ID="repeaterProdSeeMore" runat="server">
                <ItemTemplate>
                    <a href="./ViewProduct.aspx">
                        <div class="row" style="display: inline-block; margin-left: 20px;">
                            <div class="col-sm-3 col-md-3">
                                <div class="thumbnail">
                                    <img src="./Assets/<%#Eval("ImageName") %>" alt="Private Beach Picture" class="cobabanner" />
                                    <div class="captions">
                                        <h5><%#Eval("ProductName") %></h5>
                                        <p>Rp. <%#Eval("Price") %></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </a>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <!-- image-card carousel-->

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
