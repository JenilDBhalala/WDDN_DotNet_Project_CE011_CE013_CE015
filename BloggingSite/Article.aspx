<%@ Page Title="Home Article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="BloggingSite.Article" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="mytemplate col-md-12 shadow p-3 mb-5 bg-white rounded">

                <h3 id="template-title">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h3>
                <div class="template-data">
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                </div>
                <div class="template-footer">
                    <div id="like"><i class="far fa-thumbs-up" onclick="likeClicked(this)">&nbsp;&nbsp;</i><p>Like</p></div>
                    <div id="comment"><i class="far fa-comment" onclick="commentClicked(this)">&nbsp;&nbsp;</i><p>Comment</p></div>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div id="comment-box" class="col-md-8 shadow p-3 mb-5 bg-white rounded">
                <asp:Label ID="Label3" runat="server" Text="Name : "></asp:Label>&nbsp;
                <asp:TextBox ID="Name" runat="server" Placeholder="Enter your name" BorderColor="#28a745"></asp:TextBox><p></p>
                <asp:TextBox  ID="CommentBox" runat="server" Placeholder="Write Your Comment here" CssClass="write-comment" TextMode="MultiLine"  BorderColor="#28a745" Height="108px" Width="1200px"></asp:TextBox>
                <br />
                <asp:Button ID="Button3" class="btn btn-primary" OnClick="Add_Comment" runat="server" Text="Add Comment" />

                <div id="cancel-comment-button" onclick="cancelComment(this)">
                    <asp:Button ID="Button4" class="btn btn-primary" runat="server" Text="Cancel"  OnClientClick="return false;"/>
                </div>
            </div>
            <br /><br />
            <h3>Comments</h3>
          <br /><br /><br />
            <asp:Repeater ID="CommentDetails" runat="server">
                <ItemTemplate>
                    <div class="comment-template shadow-sm col-md-7 p-3 mb-5 bg-white rounded">
                        <div class="comment-username">
                            <h4><%# Eval("user_name") %></h4>
                        </div>
                        <div class="comment-data">
                            <h5> <%# Eval("blog_comment") %></>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
