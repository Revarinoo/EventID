<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="SuccessPage.aspx.cs" Inherits="EventID.View.SuccessPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://fonts.googleapis.com/css?family=Nunito+Sans:400,400i,700,900&display=swap" rel="stylesheet">
    <style>
        .successBody {
            text-align: center;
            padding: 40px 0;
        }

        .clh1 {
            color: #e87d1b;
            font-family: "Nunito Sans", "Helvetica Neue", sans-serif;
            font-weight: 900;
            font-size: 40px;
            margin-bottom: 10px;
        }

        .clp {
            color: #404F5E;
            font-family: "Nunito Sans", "Helvetica Neue", sans-serif;
            font-size: 20px;
            margin: 0;
        }

        .card1 i {
            color: #9ABC66;
            font-size: 100px;
            line-height: 200px;
            margin-left: -15px;
        }

        .card1 {
            background: white;
            padding: 60px;
            border-radius: 4px;
            box-shadow: 0 2px 3px #C8D0D8;
            display: inline-block;
            margin: 0 auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="successBody">
        <div class="card1">
            <div style="border-radius: 200px; height: 200px; width: 200px; background: #F8FAF5; margin: 0 auto;">
                <i class="checkmark" style="color: #e87d1b">✓</i>
            </div>
            <h1 class="clh1">Success</h1>
            <p class="clp">
                We received your purchase request;<br />
                we'll be in touch shortly!
            </p>
            <p style ="color : #404F5E">
                Having trouble? <a href="ContactUs.aspx" style="color: #e87d1b; padding-top:10px;" >Contact us</a>
            </p>
            <p class="lead">
                <a class="btn btn-primary btn-sm" href="Home.aspx" role="button" style="background-color: #e87d1b; border-color: #e87d1b">Continue to homepage</a>
            </p>
        </div>
    </div>
</asp:Content>
