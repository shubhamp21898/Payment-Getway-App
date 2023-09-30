<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PaymentGetway.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Page</title>
    <script src="https://js.stripe.com/v3/"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true" />

            <h1>Payment Gateway Using Stripe</h1>
            <button id="PayButton" type="button" onclick="initiateCheckout()">Pay Now Stripe</button>
        </div>
    </form>
    <script>
        var stripe;
        var sessionId;

        // Initialize Stripe.js with your publishable key
        stripe = Stripe('pk_test_51Npl1XSFNR020eHEin88gDykEHkBFRgdiAo2y50pTujt0ySOfKNwIYH5jkOuAGSDMtjcsGPNiVbysxBaU1qbqqD5004mVxWSbV'); // Replace with your Stripe publishable key

        // Handle the checkout process
        function initiateCheckout() {
            // Call the server-side method to create a Checkout session
            // This will redirect the user to the Stripe Checkout page
            PageMethods.CreateStripeCheckoutSession(onSessionCreated);
        }

        // Callback function after session creation
        function onSessionCreated(result) {
            sessionId = result;
            // Redirect to the Stripe Checkout page
            stripe.redirectToCheckout({ sessionId: sessionId });
        }
    </script>
</body>
</html>
