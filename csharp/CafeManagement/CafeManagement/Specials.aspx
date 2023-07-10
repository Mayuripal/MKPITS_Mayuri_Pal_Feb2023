<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Specials.aspx.cs" Inherits="CafeManagement.Specials" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="container">
  
  <button type="button" class="btn btn-default" data-bs-toggle="modal" data-bs-target="#myModal">
    <h4>Menu Card..</h4>
  </button>
</div>

<!-- The Modal -->
<div class="modal" id="myModal">
  <div class="modal-dialog">
    <div class="modal-content">

      <!-- Modal Header -->
      <div class="modal-header">
        
        <button type="button" class="btn-close" data-bs-dismiss="modal"></button>
      </div>

      <!-- Modal body -->
      <div class="modal-body">
        <img src="Cafe Menu Card Template - Made with PosterMyWall.jpg" style="width:100%;height:100%;"  />
      </div>

      <!-- Modal footer -->
      <div class="modal-footer">
        <button type="button" class="btn btn-danger" data-bs-dismiss="modal">Close</button>
      </div>

    </div>
  </div>
</div>

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
        </div><br />
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
</asp:Content>
