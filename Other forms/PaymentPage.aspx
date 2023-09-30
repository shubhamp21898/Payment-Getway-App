<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentPage.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Payment Page</h1>
            <asp:Button ID="btnPayNow" runat="server" Text="Pay Now" OnClick="btnPayNow_Click" />
        </div>
    </form>
</body>
</html>
