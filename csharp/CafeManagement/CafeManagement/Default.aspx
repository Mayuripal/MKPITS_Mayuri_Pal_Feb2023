<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CafeManagement._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <br />
        <div class="container">
            <div class="row">
            <div class="col-md-6">
                <img src="img1.jpg" style="width:500px;height:200px;align-items:center;"/>
            </div>
                <div class="col-md-6">
                   
                <h4 style="font-family:'Arial Rounded MT'"><b>Looking for a place to hang out with your friends?<br />
                    Or simply want to relax while sipping coffee?<br />
                    These shops have a warm ambience and seating arrangements for you to enjoy.It offers various types of coffees and savoury dishes for customers.</b>
                </h4>
                

                </div>
            </div>
        </div>
    
        <br />
        <br />
        <hr />
       <section>
           <h3>Specials.....<br /></h3>
           
        <div class="container-fluid">
        <div class="row" >
            <section class="col-md-4"  >
                <img src="c1.png" style="width:100%;"/>
            </section>
             <section class="col-md-4" >
                <img src="c3.png" style="width:100%;"/>
            </section>
             <section class="col-md-4" >
                <img src="c2.png" style="width:100%;"/>
            </section>
        </div>
            <br />
            <div class="row" >
            <section class="col-md-4"  >
                <img src="c2.png" style="width:100%;"/>
            </section>
             <section class="col-md-4" >
                <img src="c1.png" style="width:100%;"/>
            </section>
             <section class="col-md-4" >
                <img src="c3.png" style="width:100%;"/>
            </section>
        </div>
            <br />
            <div class="row" >
            <section class="col-md-4"  >
                <img src="c1.png" style="width:100%;"/>
            </section>
             <section class="col-md-4" >
                <img src="c3.png" style="width:100%;"/>
            </section>
             <section class="col-md-4" >
                <img src="c2.png" style="width:100%;"/>
            </section>
        </div>
       </div>
           </section>
    </main>
    
</asp:Content>
