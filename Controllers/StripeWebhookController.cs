using System;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http;
using FromBodyAttribute = System.Web.Http.FromBodyAttribute;

namespace YourApp.Controllers
{
    //[RoutePrefix("api/stripe/webhooks")]
    [ApiController]
    //[System.Web.Http.Route("webhook")]
    public class StripeWebhookController : ControllerBase
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("webhook")]
        public async Task<IActionResult> ProcessStripeWebhook([FromBody] string requestBody)
        {
            try
            {
                var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();

                Console.WriteLine(json);
                var stripeEvent = EventUtility.ConstructEvent(json, Request.Headers["Stripe-Signature"], "whsec_4ff9aad7d8d856eafbc6ff70eef9f6aa610b887bb2835684de4e0e1061de6f5a");
                Console.WriteLine(stripeEvent);
                // Access the event type as a string
                var eventType = stripeEvent.Type;

                if (eventType == "payment_intent.succeeded")
                {
                    Response.StatusCode = 200;
                    
                }

                return Ok();
            }
            catch (Exception ex)
            {
                // Handle any exceptions here.
                return BadRequest();
            }
        }
    }
}
