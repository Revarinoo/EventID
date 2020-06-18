<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site3.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="EventID.View.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="product.css" />
    <link rel="stylesheet" type="text/css" href="Cart.css" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <pages enableEventValidation="false"/>
    <br />
    <br />
    <div class="container-fluid">
        <div class="backgroundCart">
            <h1 class="card-subtitle judul">
                <asp:Label ID="LblCart" CssClass="pst" Text="Cart" runat="server" />
                &nbsp;<br />
            </h1>
            <div class="background" align="center">
                <asp:Label ID="TitleKosong" CssClass="title" Visible="false" runat="server">
                    <p class="title"><br />Your cart is empty<br /><br /></p>
                    <div align="center">
                        <asp:Button ID="BelanjaBtn" CssClass="buttonBlnja buttonBlnja1" Visible="false" Text="Shop Now" runat="server" />
                    </div>
                    <br />
                </asp:Label>
            </div>
            <br />
            <asp:Table ID="ListCartTable" CssClass="table backgroundTable" Visible="false" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell CssClass="text-center"><i style='font-size:18px' class='far'>&#xf14a;</i>  All Category</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-visible text-center">Price</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-visible text-center">Quantity</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-visible text-center">Total Price</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-visible text-center" ColumnSpan="1">Action</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
            <asp:Table ID="ListCart" CssClass="table table-bordered backgroundTable1 text-center" Visible="false" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell CssClass="text-center">No.</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Product</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Price</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Quantity</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center">Total Price</asp:TableHeaderCell>
                    <asp:TableHeaderCell CssClass="text-center" ColumnSpan="1">Action</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
            <br />
            <div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="LblGrandTotal" runat="server" CssClass="text-white" Font-Size="Larger" Font-Bold="True"></asp:Label>
            </div>
            <br />
            <div>
                <asp:Label ID="lblPayment" class="text-white ml-3" Text="Payment Type : " runat="server" Font-Size="Larger" Font-Bold="True" />
                <asp:DropDownList ID="DropDownListPaymentType" runat="server">
                </asp:DropDownList>
            </div>
            <div align="right">
                
                <asp:Button ID="CheckOutBtn" runat="server" class="button button1 " visible="false" Text="Checkout" OnClick="btnCheckout_Click" />
                &nbsp;&nbsp;
            </div>
            
            <br />
        </div>
    </div>
    <br />
    <br />
    <script src='https://kit.fontawesome.com/a076d05399.js'></script>
</asp:Content>
