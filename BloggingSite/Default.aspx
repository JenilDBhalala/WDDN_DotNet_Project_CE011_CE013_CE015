<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BloggingSite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%-- <div class="jumbotron">
        <h1></h1>
        <p class="lead"></p>
        <p><a href="#" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>--%>

    <%-- <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
    </div>--%>

    <h1>Latest Articles</h1>
    <hr/>
    <div>
        <asp:Repeater ID="RepBlogDetails" runat="server" OnItemCommand="RepBlogDetails_ItemCommand">
            <ItemTemplate>
                <h4><strong><%#Eval("Btitle")%></strong></h4>
                <p class="card-text">
                    <%#Eval("Bdesc") %>
                </p>
                <asp:Label ID="LblId" runat="server" Text='<%#Eval("Bid") %>' Visible="false"></asp:Label>
                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Press">Read Complete Article...</asp:LinkButton>
                <div class="card-footer text-muted">
                    Posted On : <%#Eval("Bposteddate","{0: MMMM dd yyyy}") %>
                    <a href="<%#Eval("Bcategory")%>/Home"><%#Eval("Bcategory")%></a>
                </div>
                <hr />
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
