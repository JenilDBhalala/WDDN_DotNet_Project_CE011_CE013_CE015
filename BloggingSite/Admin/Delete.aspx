<%@ Page Title="Delete Blog" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="BloggingSite.Admin.Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container">
        <br />
        <br />

        <div class="row">
            <div id="confirmMessage" runat="server" class="col-md-10 alert alert-secondary">
                <strong>Do you want to delete blog?</strong><p></p><br />
                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Yes" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" class="btn btn-light" runat="server" Text="Cancel" OnClick="Button2_Click" style="margin-left: 14" />
            </div>
        </div>
    </div>
</asp:Content>
