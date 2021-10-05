<%@ Page Title="Movies Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BloggingSite.Movies.MoviesHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="mytemplate col-md-8 shadow p-3 mb-5 bg-white rounded">
                <h3 id="template-title">Movies Articles</h3>
                <div>
                    <asp:Repeater ID="RepBlogDetails" runat="server" OnItemCommand="RepBlogDetails_ItemCommand">
                        <ItemTemplate>

                            <div class="post-template shadow p-3 mb-5 bg-white rounded">
                                <div class="post-title">
                                    <h4><%#Eval("Btitle")%></h4>
                                </div>
                                <div class="post-description">
                                    <p><%#Eval("Bdesc") %></p>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Press">Read Complete Article...</asp:LinkButton>
                                </div>
                                    <asp:Label ID="LblId" runat="server" Text='<%#Eval("Burl") %>' Visible="false"></asp:Label>
                                <div class="post-footer">
                                    <strong>Posted On</strong> : <%#Eval("Bposteddate","{0: MMMM dd yyyy}") %>  
                                &nbsp;&nbsp;&nbsp;    
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <input id="txtHidden" style="width: 28px" type="hidden" value="0" runat="server" />
                <asp:LinkButton ID="lnkBtnPrev" runat="server" Font-Underline="False" OnClick="lnkBtnPrev_Click" Font-Bold="True"><< Prev </asp:LinkButton>
                <asp:LinkButton style="padding-left:684px" ID="lnkBtnNext" runat="server" Font-Underline="False" OnClick="lnkBtnNext_Click" Font-Bold="True">Next >></asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
