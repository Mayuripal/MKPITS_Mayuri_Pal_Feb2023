<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="StateManagement.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
   
              <div class="container">
                <h1>Sign Up</h1>
                <p>Please fill in this form to create an account.</p>
                <hr/>

                <label for="email"><b>Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b></label>
                &nbsp;<input type="text" placeholder="Enter Email" name="email" required/>

                <label for="psw"><b>
                  <br />
                  <br />
                  Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b></label>
&nbsp;<input type="password" placeholder="Enter Password" name="psw" required/>

                <label for="psw-repeat"><b>
                  <br />
                  <br />
                  Repeat Password&nbsp;&nbsp;&nbsp;&nbsp; </b></label>
&nbsp;<input type="password" placeholder="Repeat Password" name="psw-repeat" required/>

                <label>
                  <br />
                  <input type="checkbox" checked="checked" name="remember" style="margin-bottom:15px"> 
                  <br />
                  Remember me&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input/>
                </label>

                <p>By creating an account you agree to our <a href="#" style="color:dodgerblue">Terms & Privacy</a>.</p>

                <div class="clearfix">
                  <button type="button" class="cancelbtn">Cancel</button>
                  <button type="submit" class="signupbtn">Sign Up</button>
                </div>
             </div>
        </form>
    </div>

        </div>
    </form>
</body>
</html>
