using Microsoft.AspNetCore.Http;
using Stripe;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaymentGetway
{
    public partial class Charge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string success = Convert.ToString(Server.UrlDecode(Request.QueryString["success"]));
            //if (success == "true") {

            //    Response.Write("Payment Successfully Done");
            //}
        }



        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Request.QueryString["success"] != null)
            {
                bool paymentSuccess = Request.QueryString["success"] == "true";

                if (paymentSuccess)
                {
                    //ProcessStripeWebhook();
                }
                else
                {
//ProcessStripeWebhook();
                }
            }
        }

        private void LogIncomingRequestDetails()
        {
            // Log request URL, headers, and other relevant information
            var requestUrl = Request.Url;
            var headers = Request.Headers;
            // Log these details to your server's logs or console for debugging
        }
        //--------------------------------------------------WebHook------------------------------------------------------//
        private void ProcessStripeWebhook()
        {
            try
            {
                // Retrieve the raw request body
                 String str=   Session.SessionID;

               
                //if (Request.HttpMethod == "POST")
                //{
                 

                    var webhookSecret = "whsec_ugQakNklnejNxE0BkCp0okNHzoYN6MDE";

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
                        System.Diagnostics.Trace.WriteLine("Json data." + json);


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
                            System.Diagnostics.Trace.WriteLine("Payment succes." + session.Id);
                            Console.WriteLine("Payment succes"+session.Id);
                        }

                        else if (stripeEvent.Type == "checkout.session.async_payment_failed")
                        {
                            // Payment failed
                            // Handle the failed payment event (e.g., notify the customer)
                            Response.Write("Payment failed");
                            System.Diagnostics.Trace.WriteLine("Payment failed.");
                        }
                        else
                        {
                            Response.Write($"Unhandled event type: {stripeEvent.Type}");
                        }

                       
                    }
                //}
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
    }
}