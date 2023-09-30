using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaymentGetway
{
    public partial class ReplaaceTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnStripe_Click(object sender, EventArgs e)
        {
            hdnfldPlan1.Value = "50";
            decimal amount = Convert.ToDecimal(hdnfldPlan1.Value);
            Response.Redirect("StripePay.aspx?amount=" + amount);
        }

        protected void BtnRazorPay_Click(object sender, EventArgs e)
        {
            hdnfldPlan2.Value = "100";
            decimal amount = Convert.ToDecimal(hdnfldPlan2.Value);


            Response.Redirect("RazorPay.aspx?amount=" + amount);
        }

        protected void BtnRazorPayPlan3_Click(object sender, EventArgs e)
        {
            hdnfldPlan3.Value = "200";
            decimal amount = Convert.ToDecimal(hdnfldPlan3.Value);
            Response.Redirect("RazorPay.aspx?amount=" + amount);
        }
    }
}