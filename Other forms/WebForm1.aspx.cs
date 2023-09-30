using Newtonsoft.Json;

using Stripe;
using Stripe.Checkout;
using System;
using System;
using System.Web.Services;

namespace PaymentGetway
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const string StripeSecretKey = "sk_test_51Npl1XSFNR020eHEVBG1x8sify9IUaESbwxIYTYavw83W8gKufIW5GTMapNzUk5dA4JKyzl38veDAvktdh7w1Jqi00AYvtfr5L";
        protected void Page_Load(object sender, EventArgs e)
        {
            StripeConfiguration.ApiKey = StripeSecretKey;
        }

        [WebMethod]
        public static string CreateStripeCheckoutSession()
        {
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new System.Collections.Generic.List<string>
                {
                    "card"
                },
                LineItems = new System.Collections.Generic.List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        Price = "10", // Replace with your actual price ID
                        Quantity = 1
                    }
                },
                Mode = "payment",
                SuccessUrl = "https://localhost:44353/Charge",
                CancelUrl = "https://yourwebsite.com/cancel"
            };

            var service = new SessionService();
            var session = service.Create(options);

            return session.Id;
        }

        // Handle webhook events
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                var json = new System.IO.StreamReader(Request.InputStream).ReadToEnd();
                var stripeEvent = EventUtility.ConstructEvent(json, Request.Headers["Stripe-Signature"], "whsec_4ff9aad7d8d856eafbc6ff70eef9f6aa610b887bb2835684de4e0e1061de6f5a");

                // Handle the Stripe webhook event based on its type
                switch (stripeEvent.Type)
                {
                    case "checkout.session.completed":
                        // Payment was successful
                        var session = stripeEvent.Data.Object as Stripe.Checkout.Session;
                        // Handle successful payment (e.g., update order status)
                        Response.Write($"Payment successful for session ID: {session.Id}");
                        break;
                    case "checkout.session.async_payment_failed":
                        // Payment failed
                        // Handle the failed payment event (e.g., notify the customer)
                        Response.Write("Payment failed");
                        break;
                    default:
                        Response.Write($"Unhandled event type: {stripeEvent.Type}");
                        break;
                }

                // Return a 200 OK response to Stripe
                Response.StatusCode = 200;
                Response.StatusDescription = "OK";
                Response.End();
            }
        }
    }
}