<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viewcart.aspx.cs" Inherits="ShopSite.viewcart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
        <table style="width: 38%; height: 501px; border: 1px solid #CC0099; margin-left: 300px">
        <tr>
            <td class="text-center" style="width: 1358px">
                <asp:Image ID="Image1" runat="server" BorderColor="#FF3399" BorderStyle="None" Height="100%" ImageUrl="~/cart.png" Width="100%" />
            </td>
        </tr>
        <tr>
            <td style="width: 1358px"><span style="color: rgb(53, 53, 67); font-family: &quot;Mier bold&quot;; font-size: 20px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 700; letter-spacing: 0.5px; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sign Up to save your order<br />
                </span></td>
        </tr>
        <tr>
            <td class="text-center" style="width: 1358px">
                <br />
                In +91&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" MaxLength="10" TextMode="Number"></asp:TextBox>
               
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 1358px">
                <br />
                <asp:Button ID="Button1" runat="server" BackColor="#FF3399" BorderStyle="None" Text="Continue" OnClick="Button1_Click" />
                <br />
            </td>
        </tr>
        <tr>
            <td class="text-center" style="width: 1358px"><span style="color: rgb(139, 139, 163); font-family: &quot;Mier demi&quot;; font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 600; letter-spacing: 0.144px; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">By continuing, you agree to Meesho’s&nbsp;</span><a href="https://www.meesho.com/legal/terms-conditions" style="padding: 0px; margin: 0px; box-sizing: border-box; background-color: rgb(255, 255, 255); text-decoration: none; font-family: &quot;Mier demi&quot;; font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 600; letter-spacing: 0.144px; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal;"><span class="sc-eDvSVe innGnA AuthWrapperstyled__StyledCaptionLink-sc-1plclw5-7 kwuflU AuthWrapperstyled__StyledCaptionLink-sc-1plclw5-7 kwuflU" color="pinkBase" font-size="12px" font-weight="demi" style="padding: 0px; margin: 0px; box-sizing: border-box; color: rgb(159, 32, 137); font-style: normal; font-weight: 600; font-size: 12px; line-height: 16px; font-family: &quot;Mier demi&quot;; cursor: pointer;">Terms 
                &amp; Conditions &nbsp;</span></a><span style="color: rgb(139, 139, 163); font-family: &quot;Mier demi&quot;; font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 600; letter-spacing: 0.144px; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">and &nbsp;</span><a href="https://www.meesho.com/legal/privacy" style="padding: 0px; margin: 0px; box-sizing: border-box; background-color: rgb(255, 255, 255); text-decoration: none; font-family: &quot;Mier demi&quot;; font-size: 12px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 600; letter-spacing: 0.144px; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal;"><span class="sc-eDvSVe innGnA AuthWrapperstyled__StyledCaptionLink-sc-1plclw5-7 kwuflU AuthWrapperstyled__StyledCaptionLink-sc-1plclw5-7 kwuflU" color="pinkBase" font-size="12px" font-weight="demi" style="padding: 0px; margin: 0px; box-sizing: border-box; color: rgb(159, 32, 137); font-style: normal; font-weight: 600; font-size: 12px; line-height: 16px; font-family: &quot;Mier demi&quot;; cursor: pointer;">Privacy 
                Policy</span></a></td>
        </tr>
    </table>
   
</asp:Content>
