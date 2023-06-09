<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ServersideStatemanagement.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Register yourself</p>
<p>
    &nbsp;</p>
<table style="width: 50%; border-collapse: collapse">
    <tr>
        <td class="text-center" style="width: 223px">Username</td>
        <td class="text-center">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-center" style="width: 223px">Email</td>
        <td class="text-center">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-center" style="width: 223px">&nbsp;</td>
        <td class="text-center">&nbsp;</td>
    </tr>
    <tr>
        <td class="text-center" style="width: 223px">&nbsp;</td>
        <td class="text-center">
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        </td>
    </tr>
    <tr>
        <td class="text-center" style="width: 223px">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="text-center">&nbsp;</td>
    </tr>
</table>
</asp:Content>
