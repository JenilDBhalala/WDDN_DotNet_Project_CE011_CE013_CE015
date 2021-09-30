﻿<%@ Page Title="Food Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BloggingSite.Food.FoodHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Food Articles</h1>
    <hr />
    <div>
        <asp:Repeater ID="RepBlogDetails" runat="server" OnItemCommand="RepBlogDetails_ItemCommand">
            <ItemTemplate>
                <b><%#Eval("Btitle")%></b>
                <p class="card-text">
                    <%#Eval("Bdesc") %>
                </p>
                <asp:Label ID="LblId" runat="server" Text='<%#Eval("Bid") %>' Visible="false"></asp:Label>
             
                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Press">Read Complete Article...</asp:LinkButton>
                <div class="card-footer text-muted">
                    Posted On : <%#Eval("Bposteddate","{0: MMMM dd yyyy}") %>
                  <%--  <a href="<%#Eval("Bcategory")%>/Home"><%#Eval("Bcategory")%></a>--%>
                </div>
                <hr />
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
