<%@ Page Title="AdminLogin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="BloggingSite.Admin.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1 id="login-title">Admin Login</h1>

        <br />
        <br />
        <div style="max-width: 400px;">
            <label for="txtUsername">Username</label>
            <asp:TextBox ID="Txtname" runat="server" CssClass="form-control" placeholder="Enter Username" />
            <br/>
            <label for="txtPassword">Password</label>
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Enter Password" />
            <br/>
            <asp:Button ID="LoginButton" Text="Login" runat="server" OnClick="LoginButton_Click" Class="btn btn-primary" />
            <br/>
            <br/>
            <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
                <strong>Please Enter Valid Username or PassWord</strong>
                <asp:Label ID="lblMessage" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
