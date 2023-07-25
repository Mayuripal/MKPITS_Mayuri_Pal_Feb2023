<%@Page EnableEventValidation="false" Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShopSite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
             <%-- front part about & image start--%>
        <div class="row" style="background-color:#e3feff">
            <section class="col-md-7" aria-labelledby="gettingStartedTitle">
                <h1 id="gettingStartedTitle">Lowest Prices
Best Quality Shopping</h1>
                <br />
                <h4> 
                   <ul>
                   <li>Free Delivery</li>
                   <li>Cash on Delivery</li>
                   <li>Easy Returns</li>
               </ul>
            </h4>
                <br />
            <a class="btn btn-success btn-md" href="https://go.microsoft.com/fwlink/?LinkId=301949">Download the Meesho App </a>


            </section>
           
            <section class="col-md-5" ">
                
                <img src="meesho.png" width="480" height="300" />
            </section>
        </div>
                                 <%-- front part about & image end--%>
        <hr />

                                  <%-- categories to chose from --%>

       <div align="center"> <h3>Top Categories to choose from</h3>
           <br />
    </div>
    <div align="center"> 
        <div class="Container-fluid">
      <HeaderTemplate>      
                        <table>      
                            <tr>      
                                <td>      
                                    <h1>Product for you</h1>      
                                </td>      
                            </tr>      
                        </table>      
                    </HeaderTemplate>  
                            
            <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" OnSelectedIndexChanged="DataList1_SelectedIndexChanged1" RepeatColumns="4" RepeatDirection="Horizontal" Width="100%">
                <ItemStyle CssClass="itemstyle" />  
                <ItemTemplate>
                     <table cellpadding="2" cellspacing="1"  style="width: 280px; height: 100px ; background-color:#ffffff">
                        <tr>
                            <td align="center">
                                <a href='<%# Eval("Prodid","ProductDetail.aspx?Prodid={0}") %>'>
                    <asp:ImageButton OnClick="Button1_Click" ID="prodimg" runat="server" ImageUrl='<%# "~/Images/" + Eval("prodimage") %>' Height="180px" Width="200px"/>
                                    </a>
                                 </td>
                         </tr>

                         <tr>
                            <td align="center">
                                
                               <b>  <asp:Label ID="lblproddescription" runat="server" Text='<%# Eval("proddescription") %>' ></asp:Label><br />
                               <asp:Label ID="lblprodid" runat="server" Text='<%# Eval("prodid") %>' Visible="false" ></asp:Label>
                                <asp:Label ID="lblprodprice" runat="server" Text='<%# Eval("prodprice") %>' ></asp:Label><br /></b>
                               
                                <span><br /></span>
                          </td>
                        </tr>
                    </table>
                          
                </ItemTemplate>
            </asp:DataList>
      
          
       </div>
</div>
                                         <%-- categories end --%>
    </main>

</asp:Content>
