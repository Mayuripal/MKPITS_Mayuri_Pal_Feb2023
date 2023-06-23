<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="checkmno.aspx.cs" Inherits="MeeshoProject.checkmno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="w-50">
        <tr>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">Enter Otp
                to verify</td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;<asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Verify" />
            </td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
