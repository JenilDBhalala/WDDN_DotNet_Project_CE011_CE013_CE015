<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BloggingSite._Default" %>

<asp:Content ID="BodyContent1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="mytemplate col-md-8 shadow p-3 mb-5 bg-white rounded">

                <h3 id="template-title">Latest Articles</h3>

                <div>
                    <asp:Repeater ID="RepBlogDetails" runat="server" OnItemCommand="RepBlogDetails_ItemCommand">
                        <ItemTemplate>
                            <div class="post-template shadow p-3 mb-5 bg-white rounded">
                                <div class="post-title">
                                    <h4><%#Eval("Btitle")%></h4>
                                </div>
                                <div class="post-description">
                                    <p><%#Eval("Bdesc") %></p>
                                    &nbsp;&nbsp
                                </div>
                                <asp:Label ID="LblId" runat="server" Text='<%#Eval("Bid") %>' Visible="false"></asp:Label>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Press">Read Complete Article...</asp:LinkButton>
                                <div class="post-footer">
                                    <strong>Posted On</strong> : <%#Eval("Bposteddate","{0: MMMM dd yyyy}") %>  
                                &nbsp;&nbsp;&nbsp;    
                                <strong>Category :</strong> <a href="<%#Eval("Bcategory")%>/Home"><%#Eval("Bcategory")%></a>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <input id="txtHidden" style="width: 28px" type="hidden" value="0" runat="server" />
                <div class="container">
                    <asp:LinkButton Style="padding-left: 20px" ID="lnkBtnPrev" runat="server" Font-Underline="False" OnClick="lnkBtnPrev_Click" Font-Bold="True"><< Prev </asp:LinkButton>
                    <asp:LinkButton Style="padding-left: 575px" ID="lnkBtnNext" runat="server" Font-Underline="False" OnClick="lnkBtnNext_Click" Font-Bold="True">Next >></asp:LinkButton>
                </div>
            </div>

            <div class="rightside col-md-4">
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
            </div>
        </div>
    </div>
</asp:Content>

