<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="MeeshoProject.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <%-- <style>
        table,th,td{
            padding:15px;
            border:1px solid lightgray;
            border-collapse:collapse;
        }
    </style>--%>

    <asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" RepeatColumns="1" Width="100%">

        <ItemTemplate>
            <table cellpadding="2" cellspacing="0" border="1" style="width: 100%; height: 400px; background-color: #ffffff">  
                   
                <tr>
                                                                    <%--image & 2 buttons --%>
                        <td>
                             <table width="100%">
                                 <tr>
                                     <td align="center" >
                                       
                                             <a href='<%# Eval("Prodid","ProductDetail.aspx?prodid={0}") %>'>
                                         <asp:Image ID="Image1" ImageUrl='<%# Bind("Images", "~/images/{0}") %>' runat="server" Height="275" Width="260" style="padding:20px;" />
                                                 

                                         </a>
                                      </td>  
                                 </tr>
                                 <tr align="center">
                                      <td>
                                        <a style="border:1px;color:white;text-decoration:none; padding:10px;border-radius:10px;background-color:green;" href='<%# Eval("Prodid","Cart.aspx?prodid={0}") %>'>Add To Cart</a>
                                             &nbsp;&nbsp;
                                        <a style="border:1px;color:white;text-decoration:none; padding:10px;border-radius:10px;background-color:green;" href="Cart.aspx" >Buy Now</a>
                                      </td>
                               
                                 </tr>
                           </table>
                        </td>
                                                                     <%--   product description--%>
                        <td >
                            <table width="100%"  >
                                <tr>
                                    <td >
                                        <span ><b> <%# Eval("Prodname") %></b></span><br /> 
                                        <span >Rs. <%# Eval("Proudprice") %> onwards</span><br /> <br />
                                        Free Delivery
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <b>Product Details</b>
                                            Name : <%# Eval("Prodname") %> <br />
                                            Description : <%# Eval("Proddescr") %> <br />
                                    
                                            Country of origin : India
                                        </td>
                                    </tr>
                            </table>

                        </td>
                    </tr>
                </table>

        </ItemTemplate>

    </asp:DataList>
</asp:Content>
