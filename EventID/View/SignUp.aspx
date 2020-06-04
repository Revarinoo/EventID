<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site3.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="EventID.View.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="custom-css.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="SignUpCard">
        <p>Sign Up</p>
        <div>
            <asp:TextBox ID="name" runat="server" placeholder="Name" CssClass="form-control FormField"></asp:TextBox>
            <asp:TextBox ID="email" runat="server" placeholder="Email" CssClass="form-control FormField"></asp:TextBox>
            <asp:TextBox ID="address" runat="server" placeholder="Address" CssClass="form-control FormField"></asp:TextBox>
            <div style="margin:0 170px 3px 180px;">
                <asp:Label ID="Label1" runat="server" Text="Gender" ForeColor="White"></asp:Label>
                <asp:RadioButtonList ID="gender" runat="server" ForeColor="White" RepeatDirection="Horizontal" Width="159px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <asp:TextBox ID="password" runat="server" placeholder="Password" CssClass="form-control FormField" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="conf_pass" runat="server" placeholder="Retype Password" CssClass="form-control FormField" TextMode="Password"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Are you a vendor ?" ForeColor="White"></asp:Label>
            <asp:CheckBox ID="vendorCheck" runat="server" ForeColor="White" Text="  Vendor ?" />
        </div>
         <div style="color:white;">
         Already a member? 
        <asp:HyperLink ID="LnkLogin"  runat="server" NavigateUrl="./Login.aspx">Login</asp:HyperLink>
        </div>
        <div>
            <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" CssClass="btn btncolor SignUpbtn" OnClick="btnSignUp_Click" />
        </div>
        <div>
        <asp:Label ID="regError" runat="server" ForeColor="White" style="margin-bottom:10px;"></asp:Label>
        </div>
    </div>
</asp:Content>
