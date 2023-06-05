<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UserManagmentex.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" language="javascript">
        function alert_meth()
        {
            alert("client side message box");
        }
        function confirm_meth()
        {
            if (confirm("Do you want to continue!click 'Yes'") == true) {
                document.writeln("<b>You had click on 'Yes' button </b>");
            }
            else
            {
                document.writeln("<b>You had click on 'No' button </b >");
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button OnClientClick="alert_meth()" ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Button OnClientClick="confirm_meth()" ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
