<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" Inherits="EventID.View.AddItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="form-horizontal">
            <h2 style="margin-top: 20px">Add Product</h2>
            <hr />
            <div class="form-group">
                <asp:Label ID="label1" runat="server" Text="Product Name" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="ProductName" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="label2" runat="server" Text="Product Price" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="ProductPrice" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="label3" runat="server" Text="Product Category" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-3">
                    <asp:DropDownList ID="ProductCategory" CssClass="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="ProductCategoryName" DataValueField="ProductCategoryName"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventID.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [ProductCategoryName] FROM [ProductCategory]"></asp:SqlDataSource>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="label4" runat="server" Text="Product Sub-Category" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-3">
                    <asp:DropDownList ID="ProductSubCategory" CssClass="form-control" runat="server" DataSourceID="SqlDataSource2" DataTextField="SubCategoryName" DataValueField="SubCategoryName"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EventID.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [SubCategoryName] FROM [SubCategory]"></asp:SqlDataSource>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="label5" runat="server" Text="Product Description" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="ProductDesc" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="label6" runat="server" Text="Product Image" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-3">
                    <asp:FileUpload ID="img1" CssClass="form-control pt-3 pb-5" runat="server" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2">
                    <div class="col-md-6">
                        <asp:Button ID="btnAdd" CssClass="btn btn-default" runat="server" Text="Add Product" OnClick="btnAdd_Click" />
                    </div>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="errormsg" runat="server" Text="" CssClass="col-md-2 control-label"></asp:Label>        
            </div>
        </div>
    </div>
</asp:Content>
