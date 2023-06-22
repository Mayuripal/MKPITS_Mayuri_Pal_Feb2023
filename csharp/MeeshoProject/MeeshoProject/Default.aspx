<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MeeshoProject._Default" %>

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
      
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Width="100%" RepeatDirection="Horizontal">
                <ItemTemplate>
                    <table cellpadding="2" cellspacing="1"  style="width: 280px; height: 100px ; background-color:#ffffff">
                        <tr>
                            <td align="center">
                                <a href='<%# Eval("Prodid","ProductDetail.aspx?Prodid={0}") %>'>
                               <asp:Image ID="Image1" ImageUrl='<%# Bind ("Images", "~/images/{0}") %>' runat="server" Height="260" Width="275" /></a>

                             </td>
                         </tr>

                         <tr>
                            <td align="center">
                                
                                <span > <%# Eval("proddescr") %></span><br />
                                <span ><b>Rs. <%# Eval("proudprice") %> </b>onwards</span><br />
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
