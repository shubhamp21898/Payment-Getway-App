using System;
using System.Web;
using Newtonsoft.Json;
using Stripe;
using Stripe.Checkout;

public partial class Checkout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.HttpMethod == "POST")
        {
            var options = new SessionCreateOptions
            {
                // Set up the session parameters, e.g., line_items, success_url, cancel_url
            };

            var service = new SessionService();
            Session session = service.Create(options);

            // Return the session ID as JSON response
            Response.ContentType = "application/json";
            Response.Write(JsonConvert.SerializeObject(new { sessionId = session.Id }));
            Response.End();
        }
    }
}
