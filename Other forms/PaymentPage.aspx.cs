using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaymentGetway
{
    public partial class PaymentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPayNow_Click(object sender, EventArgs e)
        {
            // Initialize Stripe with your secret key
            StripeConfiguration.ApiKey = "YOUR_STRIPE_SECRET_KEY";

            // Create a PaymentIntent and generate a payment link
            //var options = new PaymentIntentCreateOptions
            //{
            //    Amount = 1000,  // Amount in cents
            //    Currency = "usd",
            //};

            //var service = new PaymentIntentService();
            //var paymentIntent = service.Create(options);

            // Redirect the user to the Stripe payment link
            Response.Redirect("https://buy.stripe.com/test_5kA7sA7yA1praA0aEE");
        }
    }
}