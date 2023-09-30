<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RazorPay.aspx.cs" Inherits="PaymentGetway.RazorPay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

        <h1>Payment Gateway</h1>
        <p>Enter the amount to pay:</p>
        <asp:Button ID="payButton" class="btn btn-success" runat="server" Text="Pay Now" OnClick="payButton_Click" />

    </div>
    <%--<button id="rzp-button1">Pay with Razorpay</button>--%>
    <script src="https://checkout.razorpay.com/v1/checkout.js"></script>


</asp:Content>
