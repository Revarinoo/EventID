<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site3.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EventID.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="custom-css.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="LoginCard">
        <p>Login</p>
        <div>
            <asp:TextBox ID="email" runat="server" placeholder="Email" CssClass="form-control FormField"></asp:TextBox>
            <asp:TextBox ID="password" runat="server" placeholder="Password" CssClass="form-control FormField" TextMode="Password"></asp:TextBox>
            <asp:CheckBox ID="remMe" runat="server" ForeColor="White" Text="  Remember Me ?" />
        </div>
        <div style="color:white;">
        Not a member yet?
        <asp:HyperLink ID="LnkRegister" runat="server" NavigateUrl="./SignUp.aspx" TabIndex="5">Sign Up Now</asp:HyperLink>
        </div>
        <asp:Button ID="btnSignIn" runat="server" Text="Sign In" CssClass="btn btncolor" OnClick="btnSignIn_Click" />
        <br />
        <asp:Label ID="LoginError" runat="server" Text="" ForeColor="White"></asp:Label>
        <br />
        
        
        <%--<asp:Button ID="btnForgetPass" runat="server" Text="Forget your password?" ForeColor="White" CssClass="frgtpass" />--%>
    </div>
</asp:Content>
