<%@ Page Title="Manage Blog" Language="C#" MasterPageFile="~/Site.Master" EnableEventValidation="True" CodeBehind="Manage.aspx.cs" Inherits="BloggingSite.Manage" AutoEventWireup="True" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <div class="container">
        <table class="table table-striped table-hover">
            <thead>
                <tr>
                    <th scope="col">Blog</th>
                    <th scope="col">Date</th>
                    <th scope="col">View</th>
                    <th scope="col">Edit</th>
                    <th scope="col">Delete</th>
                    <th scope="col">Total views</th>
                </tr>
            </thead>
            <tbody>
                
                    <asp:Repeater ID="TableRows" runat="server" OnItemCommand="TableRows_ItemCommand">
                        <ItemTemplate>
                            <tr>
                            <td><%#Eval("Btitle")%></td>
                            <td><%#Eval("Bposteddate")%></td>
                            <asp:Label ID="Blogurl" runat="server" Text='<%#Eval("Burl") %>' Visible="false"></asp:Label>
                            <td><asp:Button Text="View" ID="Button1" class="btn btn-primary" runat="server" CommandName="Press1"></asp:Button></td>
                            <td><asp:button Text="Edit" Id="button2" class="btn btn-success" runat="server" Commandname="Press2"></asp:button></td>
                            <td><asp:button Text="Delete" Id="button3" class="btn btn-danger" runat="server" Commandname="Press3"></asp:button></td>
                            <td><%#Eval("view")%></td>                            
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                
            </tbody>
        </table>
    </div>
</asp:Content>


