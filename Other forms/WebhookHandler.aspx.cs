using System;
using System.IO;
using Stripe;
using System.Data.SqlClient;
using System.Configuration;
using Stripe.Checkout;
using System.Collections.Generic;

public partial class WebhookHandler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // Retrieve the raw request body
            if (Request.HttpMethod == "POST")
            {
                var webhookSecret = "whsec_4ff9aad7d8d856eafbc6ff70eef9f6aa610b887bb2835684de4e0e1061de6f5a";

                List<int> listValues = new List<int>();
                foreach (string key in Request.Form.AllKeys)
                {
                    if (key.StartsWith("List"))
                    {
                        listValues.Add(Convert.ToInt32(Request.Form[key]));
                    }
                }

                using (var reader = new StreamReader(Request.InputStream))
                {
                    var json = reader.ReadToEnd();

                    Console.WriteLine("Json data" + json);


                    // Retrieve the Stripe signature from the request headers
                    var stripeSignature = Request.Headers["Stripe-Signature"];

                    //Console.WriteLine("stripeSignature data" + stripeSignature);
                    //webhook secret key from the Stripe Dashboard



                    // Verify the Stripe signature
                    var webhookEndpointSecret = webhookSecret;
                    //var stripeEvent = Stripe.EventUtility.ConstructEvent(json, null, webhookSecret);

                    var stripeEvent = EventUtility.ConstructEvent(json, stripeSignature, webhookEndpointSecret);
                    if (stripeEvent.Type == "checkout.session.completed")
                    {
                        // Payment was successful, retrieve the Checkout Session
                        var session = stripeEvent.Data.Object as Stripe.Checkout.Session;

                        // Your code to handle successful payment (e.g., updating order status)
                        Response.Write($"Payment successful for session ID: {session.Id}");
                    }
                    else if (stripeEvent.Type == "checkout.session.async_payment_failed")
                    {
                        // Payment failed
                        // Handle the failed payment event (e.g., notify the customer)
                        Response.Write("Payment failed");
                    }
                    else
                    {
                        Response.Write($"Unhandled event type: {stripeEvent.Type}");
                    }

                    
                }
            }
        }
        catch (StripeException ex)
        {
            // Handle any Stripe signature verification errors
            // Log the error, return a 400 Bad Request, or take appropriate action
            Response.StatusCode = 400;
            Response.StatusDescription = "Bad Request";
            Response.Write("Webhook signature verification failed.");
            Response.End();
        }
        catch (Exception ex)
        {
            // Handle other exceptions
            // Log the error, return an error response, or take appropriate action
            Response.StatusCode = 500;
            Response.StatusDescription = "Internal Server Error";
            Response.Write("An error occurred while processing the webhook.");
            Response.End();
        }
    }

   
    private void SavePaymentDetailsToDatabase(SessionCustomerDetails customerDetails, PaymentIntent paymentIntent)
    {
        // Implement database connection and SQL insertion to save customer and payment details.
        // Use the customerDetails and paymentIntent objects to extract the necessary information.
        // Ensure you handle exceptions and database connection properly.
    }
}
