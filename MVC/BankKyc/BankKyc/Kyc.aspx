<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Kyc.aspx.cs" Inherits="BankKyc.Kyc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <strong>KYC Form</strong><br />
        <table align="center" class="w-50">
            <tr>
                <td class="text-center" style="width: 200px">First Name</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 200px">Last Name</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 200px">Gender</td>
                <td class="text-center">
                    <asp:RadioButton ID="RadioButtonMale" runat="server" GroupName="Gender" Text="Male" />
&nbsp;<asp:RadioButton ID="RadioButtonFemale" runat="server" GroupName="Gender" Text="Female" />
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 200px">Mobile no.</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBoxMobile" runat="server" TextMode="Number" MaxLength="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 200px">Email</td>
                <td class="text-center">
                    <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 200px">&nbsp;</td>
                <td class="text-end">
                    <asp:Button OnClientClick="return validateForm();" ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
                </td>
            </tr>
        </table>
        <br />
        
    <script type="text/javascript">
        function ValidateForm() {
            var Firstname = document.getElementById('<%=TextBoxFirstName.ClientID %>').value;
            var Lastname = document.getElementById('<%=TextBoxLastName.ClientID %>').value;
            /////////////// First name ///////////////////
            if (Firstname.trim() === '') {
                alert('Please enter First Name');
                document.getElementById('<%=TextBoxFirstName.ClientID %>').focus();
                return false;
            }
            var letters = /^[A-Za-z]+$/;
            if (Firstname.match(letters)) {

            }
            else {
                alert("Please enter only character ");
            }
            /////////////// Last name ///////////////////
            if (Lastname.trim() === '') {
                alert('Please enter First Name');
                document.getElementById('<%=TextBoxLastName.ClientID %>').focus();
                return false;
            }
            var letters = /^[A-Za-z]+$/;
            if (Lastname.match(letters)) {

            }
            else {
                alert("Please enter only character ");
            }
            ///////////// Mobile no. ////////////////////
            if (document.getElementById("<%=TextBoxMobile.ClientID%>").value == "") {
                alert("Mobile no. cannot be blank");
                document.getElementById("<%=TextBoxMobile.ClientID%>").focus();
                return false;
            }
            var number = /^\d{10}$/;
            var mobile = document.getElementById("<%=TextBoxMobile.ClientID%>").value;
            if (mobile.match(number)) {

            }
            else {
                alert("please enter valid mobile");
                return false;
            }
            /////////// Email /////////////////////
            var emailPat = /^(\".*\"|[A-Za-z]\w*)@(\[\d{1,3}(\.\d{1,3}){3}]|[A-Za-z]\w*(\.[A-Za-z]\w*)+)$/;
            var Email = document.getElementById('<%=TextBoxEmail.ClientID %>').value;
            var matchArray = Email.match(emailPat);
            if (matchArray == null) {
                alert("Your email address seems incorrect.");
                document.getElementById('<%=TextBoxEmail.ClientID %>').focus();
                return false;
            }
            return true;
        }

    </script>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
</asp:Content>
