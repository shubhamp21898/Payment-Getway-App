using System;
using System.Collections.Generic;
using System.Linq;
using Stripe;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaymentGetway.Customeize_App
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Payment  page is run");

            StripeConfiguration.ApiKey = "sk_test_51Npl1XSFNR020eHEVBG1x8sify9IUaESbwxIYTYavw83W8gKufIW5GTMapNzUk5dA4JKyzl38veDAvktdh7w1Jqi00AYvtfr5L";

            var options = new PaymentIntentCreateOptions
            {
                Amount = 500,
                Currency = "usd",
                PaymentMethod = "pm_card_visa",
            };
            var service = new PaymentIntentService();


            //Token stripeToken = tokenService.Create();
            service.Create(options);
        }

        protected void btnPay_Click(object sender, EventArgs e)
        {
            // Set your Stripe API key
            StripeConfiguration.ApiKey = "sk_test_51Npl1XSFNR020eHEVBG1x8sify9IUaESbwxIYTYavw83W8gKufIW5GTMapNzUk5dA4JKyzl38veDAvktdh7w1Jqi00AYvtfr5L";
            var tokenService = new TokenService();
            // Retrieve payment information from form
            string cardNumber = this.cardNumber.Text;
            int expMonth;
            int.TryParse(this.expMonth.Text, out expMonth);
            int expYear;
            int.TryParse(this.expYear.Text, out expYear);
            string cvc = this.cvc.Text;

            // Define the status variable and initialize it
            string status = "Payment failed. Please try again.";

            // Set your secret key. Remember to switch to your live secret key in production.
            // See your keys here: https://dashboard.stripe.com/apikeys
            StripeConfiguration.ApiKey = "sk_test_51Npl1XSFNR020eHEVBG1x8sify9IUaESbwxIYTYavw83W8gKufIW5GTMapNzUk5dA4JKyzl38veDAvktdh7w1Jqi00AYvtfr5L";

            var options = new PaymentIntentCreateOptions
            {
                Amount = 500,
                Currency = "usd",
                PaymentMethod = "pm_card_visa",
            };
            var service = new PaymentIntentService();


            //Token stripeToken = tokenService.Create();
            service.Create(options);




            if (expMonth > 0 && expYear > 0)
            {
                try
                {
                    // Create a token for the card
                    var tokenOptions = new TokenCreateOptions
                    {
                        Card = new TokenCardOptions
                        {
                            Number = cardNumber,
                            ExpMonth = expMonth.ToString(),
                            ExpYear = expYear.ToString(),
                            Cvc = cvc,
                        },
                    };
                    
                    Token stripeToken = tokenService.Create(tokenOptions);
                    System.Diagnostics.Trace.WriteLine("tokenService =======" + stripeToken);
                    // Create a charge using the token
                    var chargeOptions = new ChargeCreateOptions
                    {
                        Amount = 1000, // Amount in cents (e.g., $10.00)
                        Currency = "usd",
                        Description = "Payment for your order",
                        Source = stripeToken.Id,
                    };
                    var chargeService = new ChargeService();
                    //Charge charge = chargeService.Create(chargeOptions);
                    Stripe.Charge charge = chargeService.Create(chargeOptions);


                    // Update the status based on the payment result
                    if (charge.Status == "succeeded")
                    {
                        status = "Payment successful!";
                        // You can perform further actions here, e.g., update your database
                    }
                }
                catch (StripeException ex)
                {
                    // Handle Stripe-specific exceptions
                    status = "Payment failed: " + ex.Message;
                }
                catch (Exception ex)
                {
                    // Handle other exceptions
                    status = "An error occurred: " + ex.Message;
                }
            }

            // Display the payment status
            Response.Write(status);
        }
        }

    }


