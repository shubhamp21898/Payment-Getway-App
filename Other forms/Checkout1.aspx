<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="Checkout1.aspx.cs" Inherits="PaymentGetway.CheckOut" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stripe Checkout Example</title>
    <script src="https://js.stripe.com/v3/"></script>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Stripe Checkout Example</h1>
        <button id="checkout-button">Checkout</button>

        <script>
            var stripe = Stripe('pk_test_51Npl1XSFNR020eHEin88gDykEHkBFRgdiAo2y50pTujt0ySOfKNwIYH5jkOuAGSDMtjcsGPNiVbysxBaU1qbqqD5004mVxWSbV');

            document.getElementById('checkout-button').addEventListener('click', function () {
                fetch('/CreateCheckoutSession', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({
                        // Add any necessary data for your purchase
                    })
                }).then(function (response) {
                    return response.json();
                }).then(function (session) {
                    return stripe.redirectToCheckout({ sessionId: session.id });
                }).then(function (result) {
                    if (result.error) {
                        alert(result.error.message);
                    }
                });
            });
        </script>
    </form>
</body>
</html>


