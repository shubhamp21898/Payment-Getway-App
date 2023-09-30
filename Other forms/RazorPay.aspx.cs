using Razorpay.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaymentGetway
{
    public partial class RazorPay : System.Web.UI.Page
    {
        decimal Amount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["amount"]))
            {

                Amount = Convert.ToDecimal(Server.UrlDecode(Request.QueryString["amount"]));
            
                if (!IsPostBack)
                {
                    string key = "rzp_test_32R9DCwS0JmFWX";
                    string secret = "KQRbwdUvKb0mcnzA3HBjAIsB";
                    Session["key"] = key;
                    Session["secret"] = secret;
                
                }

            }

        }

        protected void payButton_Click(object sender, EventArgs e)
        {
            // Retrieve API key and secret from session
            string key = Session["key"].ToString();
            string secret = Session["secret"].ToString();

            // Create an instance of RazorpayClient
            RazorpayClient client = new RazorpayClient(key, secret);

            // Convert the amount to paise (Razorpay uses paise as the base unit for INR)
            int amountInPaise = (int)(Amount * 100);

            // Create a Razorpay order with USD currency
            Dictionary<string, object> orderOptions = new Dictionary<string, object>
            {
                { "amount", amountInPaise },
                { "currency", "USD" }, // Specify USD as the currency
                { "receipt", "order_rcptid_" + DateTime.Now.Ticks },
                // Add additional order options as needed
            };

            Razorpay.Api.Order order = client.Order.Create(orderOptions);

            // Get the order ID
            string orderId = order["id"].ToString();

            //Response.Redirect("https://rzp.io/i/NxRTEPER");

            Response.Write("<form action='/Charge.aspx' method='POST'>");
            Response.Write($"<script src='https://checkout.razorpay.com/v1/checkout.js' data-key='{key}' ");
            Response.Write($"data-amount='{order["amount"]}' data-currency='INR' data-order_id='{orderId}' ");
            //Response.Write("data-buttontext='Pay with Razorpay' data-name='Shubham' ");

            Response.Write("</script>");
            Response.Write("<input type='hidden' value='Hidden Element' name='hidden'></form>");

            // Redirect to Razorpay payment page

            //Response.Redirect("https://api.razorpay.com/v1/checkout/embedded?frame=1&submerchant_id=null&order_id=" + orderId);
            //Response.Redirect("https://rzp.io/i/NxRTEPER");
        }
    }
}