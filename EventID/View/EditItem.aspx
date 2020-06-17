<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="EditItem.aspx.cs" Inherits="EventID.View.EditItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .thumbnail {
            width: 200px;
            height: 150px;
            display: inline-block;
            margin: 20px 20px 20px auto;
            line-height: 1.42857143;
            background-color: #fff;
            border-radius: 25px;
            -webkit-transition: border .2s ease-in-out;
            -o-transition: border .2s ease-in-out;
            transition: border .2s ease-in-out;
        }
        .cobabanner {
            height: 100px;
            width: 100%;
            background-size: cover;
            background-position: center;
            border-top-left-radius: 25px; 
            border-top-right-radius: 25px;
        }

        .captions {
            text-align: left;
            caption-side: bottom;
        }

        .captions p, .captions h5 {
            color: #e87d1b;
            margin-bottom: -3px;
            margin-left: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <asp:Repeater ID="repeaterEditItem" Visible="true" runat="server">
            <ItemTemplate>
                <a href="./EditItems.aspx?ID=<%#Eval("ProductID") %>">
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
</asp:Content>
