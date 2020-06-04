<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site3.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="EventID.View.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="product.css" />
    <link rel="stylesheet" type="text/css" href="Cart.css" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container-fluid">
        <div class="backgroundCart">
            <h1 class="card-subtitle judul">
                <asp:Label ID="LblCart" class="pst" Text="Cart" runat="server" />
                &nbsp;<br />
            </h1>
            <div class="background" align="center">
                <asp:Label ID="TitleKosong" class="title" Visible="false" runat="server"></asp:Label>
                    <p class="title"><br />Your cart is empty<br /><br /></p>
                    
                    <div align="center">
                        <asp:Button id="BelanjaBtn" class="buttonBlnja buttonBlnja1" visible="false" OnClick="btnShop_Click" Text="Shop Now" runat="server" />
                    </div>
                    
                    <br />
                
            </div>
            <br />
            <asp:Table ID="ListCartTable" class="table backgroundTable" Visible="false" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell class="text-center"><i style='font-size:18px' class='far'>&#xf14a;</i>  All Category</asp:TableHeaderCell>
                    <asp:TableHeaderCell class="text-visible text-center">Price</asp:TableHeaderCell>
                    <asp:TableHeaderCell class="text-visible text-center">Quantity</asp:TableHeaderCell>
                    <asp:TableHeaderCell class="text-visible text-center">Total Price</asp:TableHeaderCell>
                    <asp:TableHeaderCell class="text-visible text-center" ColumnSpan="1">Action</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
            <asp:Table ID="ListCart" class="table table-bordered backgroundTable1 text-center" Visible="false" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell class="text-center">No.</asp:TableHeaderCell>
                    <asp:TableHeaderCell class="text-center">Product</asp:TableHeaderCell>
                    <asp:TableHeaderCell class="text-center">Price</asp:TableHeaderCell>
                    <asp:TableHeaderCell class="text-center">Quantity</asp:TableHeaderCell>
                    <asp:TableHeaderCell class="text-center">Total Price</asp:TableHeaderCell>
                    <asp:TableHeaderCell class="text-center" ColumnSpan="1">Action</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
            <br />
            <div align="right">
                <button id="CheckOutBtn" class="button button1" visible="false" runat="server">Check Out</button>
                &nbsp;&nbsp;
            </div>
            
            <br />
        </div>
    </div>
    <br />
    <br />
    <script src='https://kit.fontawesome.com/a076d05399.js'></script>
</asp:Content>
