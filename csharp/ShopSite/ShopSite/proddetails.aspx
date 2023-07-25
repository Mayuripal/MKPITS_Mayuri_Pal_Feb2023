<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="proddetails.aspx.cs" Inherits="ShopSite.proddetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
      <style>
        table,th,td{
            padding:15px;
            border-collapse:collapse;
        }
    </style>

    <asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" RepeatColumns="1" Width="100%" Height="1367px" RepeatDirection="Horizontal">
    <ItemTemplate>
         <table cellpadding="4" cellspacing="0" border="1" style="width: 100%; height:100px; background-color:#f6f6f6";>  
                   
                <tr>
                    
                                          <%--image & 2 buttons --%>
       <td>
           <table >
               <tr>
                    <td align="center" >  
                    <asp:Label ID="lblprodimage" runat="server" text='<%# Eval("prodimage") %>' visible="false" />      
                   
                    <asp:ImageButton ID="prodimg" runat="server" ImageUrl='<%# "~/Images/" + Eval("prodimage") %>' Height="275px" Width="260px" />      
                    </td> 
                </tr>

                <tr>
                    <td align="center">
                        <asp:Button OnClick="Button1_Click" ID="Button1" runat="server" Text="Add To Cart" Height="50px" Width="200px"></asp:Button>
                   
                        <asp:Button OnClick="Button2_Click" ID="Button2" runat="server" Text="View Cart" Height="50px" Width="200px"></asp:Button>
                    </td>
                </tr>
            </table>
        </td>

                                           <%--   product description--%>
         <td >
             <table width="100%" style="font-family:'Times New Roman', Times, serif ;font-size:20px;" >
                  <tr>
                   <td >
                       <asp:Label ID="Label1" runat="server" Text='<%# Eval("prodname") %>'> </asp:Label>    
                   </td>
                </tr>
                <tr>
                   <td >
                       <asp:Label ID="lblproddescription" runat="server" Text='<%# Eval("proddescription") %>'> </asp:Label>    
                   </td>
                </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblprodid" runat="server" Text='<%# Eval("prodid") %>' visible="false"></asp:Label>
                                          Price :     <asp:Label ID="lblprodprice" runat="server" Text='<%# Eval("prodprice") %>'>      
                                                </asp:Label>  Rs.    

                             </td>
                         </tr>
                    </table>
                 </td>
              </tr>
          </table>
    </ItemTemplate>

    </asp:DataList>
        </div>
</asp:Content>
