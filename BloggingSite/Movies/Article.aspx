<%@ Page Title="Movies Article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="BloggingSite.Movies.MoviesArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--  <asp:Label ID="IdLbl" runat="server" Text=""></asp:Label>--%>
    <div class="container">
        <div class="row">
            <div class="mytemplate col-md-14 shadow p-3 mb-5 bg-white rounded">

                <h3 id="template-title">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h3>
                <div class="template-data">
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </div>
            </div>

          <%--  <div class="rightside col-md-4">
                <div id="rightside-tag" class="shadow p-3 mb-5 bg-white rounded">
                    <h3 class="rightside-title">Tags</h3>
                    <div class="button-group">
                        <button class="btn btn-secondary">Food</button>
                        <button class="btn btn-secondary">Education</button>
                        <button class="btn btn-secondary">Sports</button>
                        <button class="btn btn-secondary">Technology</button>
                        <button class="btn btn-secondary">Politics</button>
                        <button class="btn btn-secondary">International</button>
                        <button class="btn btn-secondary">Business</button>
                        <button class="btn btn-secondary">Arts</button>
                        <button class="btn btn-secondary">Stock Market</button>
                        <button class="btn btn-secondary">Bollywood</button>
                        <button class="btn btn-secondary">Festival</button>
                    </div>
                </div>
            </div>--%>
        </div>
    </div>
</asp:Content>
