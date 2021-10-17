<%@ Page Title="Edit Blog" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="BloggingSite.Admin.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container">
        
        <div class="row">

            <div id="confirmMessage" runat="server" visible="false" class="col-md-10 alert alert-success">
                <strong>Do you want to update blog ?</strong><p></p><br />
                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Yes" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" class="btn btn-light" runat="server" Text="Cancel" OnClick="Button2_Click" style="margin-left: 14" />
            </div>
            <div class="mytemplate col-md-10 shadow p-5 mb-7 bg-white rounded">
                <script src="../Scripts/ckeditor/ckeditor.js"></script>
                <script src="../Scripts/ckfinder/ckfinder.js"></script>
                <h2 id="template-title">Admin Panel - Edit Blog</h2>
                <div class="form-group px-5">
                    <label for="exampleFormControlInput1">Blog Category</label>
                    <asp:DropDownList class="form-control" ID="ListBlogCat" runat="server" BorderColor="#28a745">
                    </asp:DropDownList>
                </div>
                <div class="form-group px-5">
                    <label for="exampleFormControlSelect1">Blog Title</label>
                    <asp:TextBox class="form-control" ID="TxtBlogTitle" runat="server" BorderColor="#28a745"></asp:TextBox>
                </div>
                <div class="form-group px-5">
                    <label for="exampleFormControlSelect2">Blog Description</label>
                    <asp:TextBox class="form-control" ID="TxtBlogDesc" runat="server" TextMode="MultiLine" BorderColor="#28a745"></asp:TextBox>
                </div>
                <div class="form-group px-5">
                    <label for="exampleFormControlSelect1">Blog URL : </label>
                    <asp:TextBox runat="server" Value="www.blogscope.com/" ReadOnly=true></asp:TextBox>&nbsp;
                    <asp:TextBox ID="URL" style="width:100%;"  runat="server" BorderColor="#28a745" ></asp:TextBox>
                </div>
                
                <div class="form-group px-5">
                    <label for="exampleFormControlTextarea1">Type Your Blog</label>
                    <div class="editor" style="border: 1px solid green">
                        <asp:TextBox class="form-control ckeditor" ID="TxtFullBlog" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group px-5">
                    <label for="exampleFormControlTextarea1">Posted Date</label>
                    <asp:Label class="form-control" ID="LblBlogPostedDate" runat="server" Text="" BorderColor="#28a745"></asp:Label>
                </div>
                <div class="form-group px-5">
                    <asp:Button ID="SubmitButton" class="btn btn-primary" runat="server" Text="Update" OnClick="SubmitButton_Click"/>
                </div>
            </div>
            
        </div>
    </div>
</asp:Content>
