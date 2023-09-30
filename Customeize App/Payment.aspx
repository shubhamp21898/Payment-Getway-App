<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="PaymentGetway.Customeize_App.Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="paymentForm" runat="server">
        <!-- Add your payment form fields here -->
        <asp:TextBox ID="cardNumber" runat="server" placeholder="Card Number"></asp:TextBox>
        <asp:TextBox ID="expMonth" runat="server" placeholder="Expiry Month"></asp:TextBox>
        <asp:TextBox ID="expYear" runat="server" placeholder="Expiry Year"></asp:TextBox>
        <asp:TextBox ID="cvc" runat="server" placeholder="CVC"></asp:TextBox>

        <asp:Button ID="btnPay" runat="server" Text="Pay Now" OnClick="btnPay_Click" />
    </form>
</body>
</html>
