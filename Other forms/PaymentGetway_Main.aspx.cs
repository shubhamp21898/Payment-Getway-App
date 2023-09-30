using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaymentGetway
{
    public partial class PaymentGetway_Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStripe_Click(object sender, EventArgs e)
        {
            Response.Redirect("StripePay.aspx");
        }

        protected void BtnRazorPay_Click(object sender, EventArgs e)
        {
            Response.Redirect("RazorPay.aspx");
        }
    }
}