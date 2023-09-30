using System;
using System.IO;
using System.Web;
using Newtonsoft.Json.Linq;
using Stripe;
using Stripe.Checkout;
using PaymentGetway.BL;
using PaymentGetway.Models;
using System.Configuration;

public class StripeWebhookHandler : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        var configuration = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~");
        var connectionString = configuration.ConnectionStrings.ConnectionStrings["DefaultConnection"].ConnectionString;
       // var paymentDataRepository = new PaymentDataRepository(new Configuration { ConnectionStrings = connectionString });
        //var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        // Initialize Stripe with your secret key
        StripeConfiguration.ApiKey = "sk_test_51Npl1XSFNR020eHEVBG1x8sify9IUaESbwxIYTYavw83W8gKufIW5GTMapNzUk5dA4JKyzl38veDAvktdh7w1Jqi00AYvtfr5L";
        Console.WriteLine($"Payment ashx webhook");

        const string secret = "whsec_vfapGpsCLTFaIBgDctJhNqoNt4lfGcZ2";
        var json = new StreamReader(context.Request.InputStream).ReadToEnd();

        try
        {
            var stripeEvent = EventUtility.ConstructEvent(
                json,
                context.Request.Headers["Stripe-Signature"],
                secret
            );

            switch (stripeEvent.Type)
            {
                case Events.PaymentIntentSucceeded:
                    var paymentIntent = stripeEvent.Data.Object as PaymentIntent;

                    // Extract the exampleCountry from the paymentIntent
                    // var exampleCountry = paymentIntent.Metadata.GetValueOrDefault("exampleCountry");
                    Console.WriteLine($"Received Stripe webhook event: {stripeEvent.Type}, Timestamp: {stripeEvent.Created}");

                    // Create a PaymentData object with the data to insert
                    var paymentData = new PaymentData
                    {
                        AccountId = paymentIntent.Id, // You can use paymentIntent.Id or any other relevant data
                       // Country = exampleCountry
                    };

                    // Insert payment data into the database
                    PaymentDataRepository obj
                        = new PaymentDataRepository();
                    obj.InsertPaymentData(paymentData);

                    Console.WriteLine($"Payment Succeeded {paymentIntent.Id} for ${paymentIntent.Amount}");

                    System.Diagnostics.Trace.WriteLine($"Payment Succeeded {paymentIntent.Id} for ${paymentIntent.Amount}");
                    break;

                case Events.ChargeSucceeded:
                    var charge = stripeEvent.Data.Object as Charge;
                    // Handle the charge success event
                    Console.WriteLine($"Charge Succeeded {charge.Id} for ${charge.Amount}");
                    System.Diagnostics.Trace.WriteLine($"Charge Succeeded {charge.Id} for ${charge.Amount}");
                    break;
                default:
                    Console.WriteLine($"Got event {stripeEvent.Type}");
                    break;
            }
        }
        catch (StripeException e)
        {
            Console.WriteLine(e);
            throw e;
        }
    }

    public bool IsReusable
    {
        get { return false; }
    }
}
