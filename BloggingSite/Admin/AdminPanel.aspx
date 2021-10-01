﻿<%@ Page Title="AdminPanel" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="BloggingSite.Admin.AdminPanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <script src="../Scripts/ckeditor/ckeditor.js"></script>
        <script src="../Scripts/ckfinder/ckfinder.js"></script>
        <h1>Admin Panel</h1>
        <hr />


        <div class="form-group">
            <label for="exampleFormControlInput1">Blog Category</label>
            <asp:DropDownList class="form-control" ID="ListBlogCat" runat="server" BorderColor="#28a745">
                <asp:ListItem runat="server">Food</asp:ListItem>
                <asp:ListItem runat="server">Movies</asp:ListItem>
                <asp:ListItem runat="server">Sports</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="exampleFormControlSelect1">Blog Title</label>
            <asp:TextBox class="form-control" ID="TxtBlogTitle" runat="server" BorderColor="#28a745" ></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleFormControlSelect2">Blog Description</label>
            <asp:TextBox class="form-control" ID="TxtBlogDesc" runat="server" TextMode="MultiLine" BorderColor="#28a745"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleFormControlTextarea1">Type Your Blog</label>
            <div class="editor" style="border:1px solid green">
                <asp:TextBox class="form-control ckeditor" ID="TxtFullBlog" runat="server" TextMode="MultiLine" ></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label for="exampleFormControlTextarea1">Posted Date</label>
            <asp:Label class="form-control" ID="LblBlogPostedDate" runat="server" Text="" BorderColor="#28a745"></asp:Label>
        </div>
        <asp:Button ID="SubmitButton" class="btn btn-primary" runat="server" Text="Save" OnClick="SubmitButton_Click" />

    </div>
</asp:Content>
