<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="EFLIERSITE.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            border-collapse: collapse;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style2 {
            width: 148px;
            text-align: left;
        }
        .auto-style4 {
            width: 148px;
            text-align: center;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <h1 align=center class="text-white"><strong>sign up</strong><br />
       <br />
       <table class="auto-style1" align="center">
           <tr>
               <td class="auto-style4">User Name</td>
               <td>
                   <asp:TextBox ID="TextBox1" runat="server" Width="236px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="auto-style4">Password</td>
               <td>
                   <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="238px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="auto-style2">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td class="auto-style2">&nbsp;</td>
               <td>
                   <asp:Button ID="Button1" runat="server" Text="Submit" />
               </td>
           </tr>
       </table>
    </h1>

       
    
</asp:Content>
