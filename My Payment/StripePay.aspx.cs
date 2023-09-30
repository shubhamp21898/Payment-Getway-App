using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.BillingPortal;
using Stripe.Checkout;
using Stripe.FinancialConnections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json.Linq;
using SessionCreateOptions = Stripe.Checkout.SessionCreateOptions;
using SessionService = Stripe.Checkout.SessionService;
using PaymentGetway.BL;
using System.Data;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace PaymentGetway
{
    public partial class StripePay : System.Web.UI.Page
    {
        public string SessionId = "";
        decimal Amount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            System.Diagnostics.Trace.WriteLine("StripePay page is run");
            if (!string.IsNullOrEmpty(Request.QueryString["amount"]))
            {
                Amount = Convert.ToDecimal(Server.UrlDecode(Request.QueryString["amount"]));
                if (!IsPostBack)
                {
                    StripeConfiguration.ApiKey = "sk_test_51Npl1XSFNR020eHEVBG1x8sify9IUaESbwxIYTYavw83W8gKufIW5GTMapNzUk5dA4JKyzl38veDAvktdh7w1Jqi00AYvtfr5L";
                    Session["ApiKey"] = StripeConfiguration.ApiKey;

                }

            }
                


        }

        //Button click event
        protected void CreateCheckoutSession_Click(object sender, EventArgs e)
        {
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = Convert.ToInt64(Amount) * 100,
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "Premium",
                        },
                    },
                    Quantity = 1,
                },
            },
                Mode = "payment",
                SuccessUrl = "https://localhost:44353/My%20Payment/Charge",
                CancelUrl = "https://localhost:44353/StripePay/?success=false",
            };

            var service = new SessionService();
            var session = service.Create(options);

            string str=session.Url; 
            Response.Redirect(session.Url);




            //var paymentData = new
            //{
            //    SessionId = session.Id,
            //    Amount = session.AmountTotal / 100,
            //   PaymentI= options.PaymentIntentData,
            //};

            // Serialize the payment data to JSON
            //var paymentDataJson = JsonConvert.SerializeObject(paymentData);

            //// Send a POST request to your webhook endpoint
            //SendPaymentDataToWebhook(paymentDataJson);

        }



        private void SendPaymentDataToWebhook(string paymentDataJson)
        {
            // Send a POST request to your webhook endpoint (StripeWebhook.aspx)
            // Include the payment data in the request body
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var response = client.UploadString("http://localhost:5106/api/Webhook/webhook", "POST", paymentDataJson);

                // Handle the response as needed
                if (response == "Success")
                {
                    Response.Write(response);   
                }
                else
                {
                    // Handle errors or responses from the webhook
                }
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            //if (Request.QueryString["success"] != null)
            //{
            //    bool paymentSuccess = Request.QueryString["success"] == "true";

            //    if (paymentSuccess)
            //    {
            //        //Response.Redirect("https://localhost:44353/Charge/?success=true");

            //        //HttpClient httpClient = new HttpClient();
            //        //httpClient.BaseAddress = new Uri("https://localhost:4242/Webhook");

            //        //LogIncomingRequestDetails();
            //       // ProcessStripeWebhook();


            //        //using (var client = new HttpClient())
            //        //{
            //        //    // Set the base address of your API
            //        //    client.BaseAddress = new Uri("https://localhost:44353/"); // Replace with the actual URL

            //        //    // Call your Web API endpoint
            //        //    HttpResponseMessage response = client.GetAsync("api/stripe/webhooks/process").Result;

            //        //    // Check the response status
            //        //    if (response.IsSuccessStatusCode)
            //        //    {
            //        //        // Handle a successful response
            //        //        string result = response.Content.ReadAsStringAsync().Result;
            //        //        // Process the result as needed
            //        //    }
            //        //    else
            //        //    {
            //        //        // Handle an error response
            //        //        // You can access response.StatusCode and response.Content to get more details
            //        //    }
            //        //}


            //        //Response.Redirect("Charge.aspx");
            //    }
            //    else
            //    {
            //        ProcessStripeWebhook();
            //        //Response.Redirect("Cancel.aspx");
            //    }
            //}
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

                        //Json to datatable

                        //List<JObject> jsonObjects = JArray.Parse(json).ToObject<List<JObject>>();

                        //// Create a DataTable to represent the dynamic data
                        //DataTable dataTable = new DataTable();

                        // Determine columns dynamically based on JSON keys
                        //foreach (JObject jsonObject in jsonObjects)
                        //{
                        //    foreach (JProperty property in jsonObject.Properties())
                        //    {
                        //        if (!dataTable.Columns.Contains(property.Name))
                        //        {
                        //            dataTable.Columns.Add(property.Name);
                        //        }
                        //    }
                        //}

                        //// Populate the DataTable
                        //foreach (JObject jsonObject in jsonObjects)
                        //{
                        //    DataRow row = dataTable.NewRow();
                        //    foreach (JProperty property in jsonObject.Properties())
                        //    {
                        //        row[property.Name] = property.Value.ToString();
                        //    }
                        //    dataTable.Rows.Add(row);
                        //}


                        // Handle the event based on its type
                        //if (stripeEvent.Type == "payment_intent.succeeded")
                        //{

                        //    //Insert the data in Database
                        //    //  StripePaymentBL.GetInstance.Insert_FreedomB_Payment(dataTable);
                        //}
                        //else if (stripeEvent.Type == "payment_intent.payment_failed")
                        //{
                        //    //Insert the data in Database
                        //    //  StripePaymentBL.GetInstance.Insert_FreedomB_Payment();
                        //}

                        //// Return a 200 OK response to Stripe
                        //Response.StatusCode = 200;
                        //Response.StatusDescription = "OK";
                        //Response.End();
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

        //--------------------------------------------------WebHook------------------------------------------------------//
        protected void payButton_Click(object sender, EventArgs e)
        {
            //string ApiKey = Session["ApiKey"].ToString();
            //var optionsProduct = new ProductCreateOptions
            //{
            //    Name = "Starter Subscription",
            //    Description = "$12/Month subscription",
            //};
            //var serviceProduct = new ProductService();
            //Product product = serviceProduct.Create(optionsProduct);
            //Console.Write("Success! Here is your starter subscription product id: {0}\n", product.Id);

            //var optionsPrice = new PriceCreateOptions
            //{
            //    UnitAmount = 1200,
            //    Currency = "usd",
            //    Recurring = new PriceRecurringOptions
            //    {
            //        Interval = "month",
            //    },
            //    Product = product.Id
            //};
            //var servicePrice = new PriceService();
            //Price price = servicePrice.Create(optionsPrice);


            //Console.Write("Success! Here is your starter subscription price id: {0}\n", price.Id);
            

            

            CheckOutStripe(Amount);
        }
        public void CheckOutStripe(decimal amount)
        {
            //var options = new Stripe.Checkout.SessionCreateOptions
            //{
            //    LineItems = new List<SessionLineItemOptions>
            //    {
            //      new SessionLineItemOptions
            //      {
            //        PriceData = new SessionLineItemPriceDataOptions
            //        {
            //          UnitAmount =Convert.ToInt64(amount)*100,
            //          Currency = "usd",
            //          ProductData = new SessionLineItemPriceDataProductDataOptions
            //          {
            //            Name = "Premium",
            //          },

            //        },
            //        Quantity = 1,
            //      },
            //    },
            //    Mode = "payment",
            //    SuccessUrl = "https://localhost:44353/StripePay/?success=true",
            //    CancelUrl = "https://localhost:44353/StripePay/?success=",
            //};

            //var service = new Stripe.Checkout.SessionService();
            //Stripe.Checkout.Session session = service.Create(options);

            //Response.Headers.Add("Location", session.Url);
            ////Response.Headers.Add("Location", session.Url);
            //Response.Redirect(session.Url, true);
            Response.Redirect("https://buy.stripe.com/test_5kA7sA7yA1praA0aEE");
        }
    }
}
