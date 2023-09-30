using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Stripe;

[ApiController]
[Route("webhook")]
public class StripeWebhookController : ControllerBase
{
    [HttpPost]
    public IActionResult HandleWebhook()
    {
        const string secret = "YOUR_STRIPE_WEBHOOK_SECRET"; // Your webhook secret from Stripe

        var json = new StreamReader(HttpContext.Request.Body).ReadToEnd();

        try
        {
            var stripeEvent = EventUtility.ConstructEvent(
                json,
                Request.Headers["Stripe-Signature"],
                secret
            );

            // Handle the webhook event based on its type
            switch (stripeEvent.Type)
            {
                case Events.PaymentIntentSucceeded:
                    // look up the payment in the database and update it's state
                    // fulfill order
                    // send a customer email
                    // 
                    var paymentIntent = stripeEvent.Data.Object as PaymentIntent;

                    //Insert the data in Database
                    //StripePaymentBL.GetInstance.Insert_FreedomB_Payment(dataTable);

                    Console.WriteLine($"Payment Succeeded {paymentIntent.Id} for ${paymentIntent.Amount}");
                    break;
                default:

                    //StripePaymentBL.GetInstance.Insert_FreedomB_Payment(dataTable);
                    Console.WriteLine($"Got event {stripeEvent.Type}");
                    break;
            }

            return Ok(); // Return a 200 OK for successful handling
        }
        catch (StripeException e)
        {
            return BadRequest(new { error = e.Message });
        }
    }
}
