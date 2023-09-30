<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Charge.aspx.cs" Inherits="PaymentGetway.Charge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        h3{
            color:forestgreen;
        }
    </style>
</head>
<body>
    <form id="form1" method="post" runat="server">
        <div id="PaymentSuccess">
            <h3>Payment Successfully Done</h3>

        </div>
      <!-- Add a button or link on Success.aspx to trigger the POST request -->
<%--<button id="postToWebhookButton">Send POST Request to Webhook</button>

<script>
  document.getElementById('postToWebhookButton').addEventListener('click', function () {
    // Prepare the data to send (if needed)
    var postData = {
      key1: 'value1',
      key2: 'value2',
      // Add any additional data needed for your webhook
    };

    // Send a POST request to your webhook endpoint
    fetch('StripeWebhook.aspx', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(postData),
    })
      .then(function (response) {
        if (response.ok) {
          // Webhook request was successful
          console.log('POST request to webhook was successful');
        } else {
          // Handle errors here
          console.error('POST request to webhook failed');
        }
      })
      .catch(function (error) {
        // Handle network errors here
        console.error('Network error:', error);
      });
  });
</script>--%>

    </form>
</body>
</html>
