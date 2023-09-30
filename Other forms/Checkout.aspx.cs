using Newtonsoft.Json;

using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaymentGetway
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                var options = new SessionCreateOptions
                {
                    LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = Convert.ToInt64(50) * 100,
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
                    SuccessUrl = "https://localhost:44353/WebHookHandler",
                    CancelUrl = "https://localhost:44353/WebHookHandler",
                };

                var service = new SessionService();
                Session session = service.Create(options);

                // Return the session ID as JSON response
                Response.ContentType = "application/json";
                Response.Write(JsonConvert.SerializeObject(new { sessionId = session.Id }));

                //string str = session.Url;
                //Response.Redirect(session.Url);
                Response.End();
            }
        }
    }
}