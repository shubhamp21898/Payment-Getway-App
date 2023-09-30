using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PaymentGetway.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaymentGetway
{
    public partial class PaymentMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Write("CategoryName", "Your message here");

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
            decimal amount=Convert.ToDecimal(hdnfldPlan2.Value);


            Response.Redirect("RazorPay.aspx?amount=" + amount);
        }

        protected void BtnRazorPayPlan3_Click(object sender, EventArgs e)
        {
            hdnfldPlan3.Value = "200";
            decimal amount = Convert.ToDecimal(hdnfldPlan3.Value);
            Response.Redirect("RazorPay.aspx?amount="+ amount);
        }

        protected  void BtnPaypal_Click(object sender, EventArgs e)
        {
            // PayPal API endpoint (sandbox)
            string apiUrl = "https://api.sandbox.paypal.com/v1/";
            string apiUrl2 = "https://api-m.sandbox.paypal.com/v1/oauth2/token";

            // Your PayPal API credentials
            string clientId = "AYobRH56SeyfVBh0MS4hPad3P7tJ8NVIoQOeiE3l8hcA3IE_ktoxJodrFZ3kC9-2WMRso-Fl6bGQpxVd";
            string clientSecret = "EAWFW0UjbK-DTgcMYVFoOqS3AKOz_9g_gwSPVNLfdnUoTp3BBqIOtEIUs8ZmAqmkkc3I6pAqjtmUtNOL";

            // Plan data fetched from the database
            string planName = "Monthly";
            string planType = "REGULAR";
            string planFrequency = "MONTH";
            string planFrequencyInterval = "1";
            string planCycles = "0";
            decimal planAmount = 10.0M;
            string planCurrency = "USD";


            Task.Run(async () =>
            {
                // Use Task.Run to offload the asynchronous operation to a separate thread
              //  string accessToken = await GetAccessToken(apiUrl, clientId, clientSecret);
        //        string planId = await CreateSubscriptionPlan(apiUrl, accessToken, planName, planType, planFrequency, planFrequencyInterval, planCycles, planAmount, planCurrency);

                // Handle the result, e.g., update the UI or perform other actions
                //UpdateUIWithPlanId(planId);
         //   Response.Write("Created PayPal Subscription Plan with Plan ID: " + planId);
            });
            // Call the methods to create the PayPal subscription plan
            //string accessToken =  GetAccessToken(apiUrl, clientId, clientSecret);
            //string planId =  CreateSubscriptionPlan(apiUrl, accessToken, planName, planType, planFrequency, planFrequencyInterval, planCycles, planAmount, planCurrency);

            // Do something with the planId, e.g., display it to the user
        }
        //static async Task<string> GetAccessToken(string apiUrl, string clientId, string clientSecret)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        // Set the API endpoint for getting an access token
        //        string tokenUrl = apiUrl + "oauth2/token";

        //        // Create the token request body
        //        string tokenRequestBody = $"grant_type=client_credentials";
        //        var tokenRequestContent = new StringContent(tokenRequestBody, Encoding.UTF8, "application/x-www-form-urlencoded");

        //        // Add the client ID and secret for authentication
        //        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
        //            "Basic",
        //            Convert.ToBase64String(Encoding.ASCII.GetBytes($"{clientId}:{clientSecret}"))
        //        );

        //        // Send the token request
        //        var tokenResponse = await client.PostAsync(tokenUrl, tokenRequestContent);

        //        // Read the response content as a JSON string
        //        string tokenResponseContent = await tokenResponse.Content.ReadAsStringAsync();

        //        // Deserialize the JSON response to an object
        //       // var tokenResponseObject = JsonConvert.DeserializeObject<TokenResponse>(tokenResponseContent);

        //        // Access the access_token property from the deserialized object
        //        //string accessToken = tokenResponseObject.access_token;

        //        return accessToken;
        //    }
        //}

        static async Task<string> CreateSubscriptionPlan(string apiUrl, string accessToken, string planName, string planType, string planFrequency, string planFrequencyInterval, string planCycles, decimal planAmount, string planCurrency)
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    // Set the API endpoint for creating a subscription plan
            //    string createPlanUrl = apiUrl + "billing/plans";

            //    // Create the plan request body
            //    string planRequestBody = $@"
            //{{
            //    ""name"": ""{planName}"",
            //    ""description"": ""{planName} subscription plan"",
            //    ""type"": ""{planType}"",
            //    ""payment_definitions"": [
            //        {{
            //            ""name"": ""{planName}"",
            //            ""type"": ""{planType}"",
            //            ""frequency"": ""{planFrequency}"",
            //            ""frequency_interval"": ""{planFrequencyInterval}"",
            //            ""cycles"": ""{planCycles}"",
            //            ""amount"": {{
            //                ""value"": ""{planAmount.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}"",
            //                ""currency"": ""{planCurrency}""
            //            }}
            //        }}
            //    ],
            //    ""merchant_preferences"": {{
            //        ""cancel_url"": ""YOUR_CANCEL_URL"",
            //        ""return_url"": ""YOUR_RETURN_URL""
            //    }}
            //}}";

            //    var createPlanRequestContent = new StringContent(planRequestBody, Encoding.UTF8, "application/json");

            //    // Add the access token for authentication
            //    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            //    // Send the plan creation request
            //    var createPlanResponse = await client.PostAsync(createPlanUrl, createPlanRequestContent);

            //    // Parse the response to get the plan ID
            //    string createPlanResponseContent = await createPlanResponse.Content.ReadAsStringAsync();


            //    Console.WriteLine("PayPal API Response: " + createPlanResponseContent);

            //    string planId = createPlanResponseContent.Split(':')[1].Trim('"');

            //    return planId;
            //}





            using (HttpClient httpClient = new HttpClient())
        {
                // Set the Authorization header with the access token
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                var requestBody = new
                {
                    product_id = "PROD-XXCD1234QWER65782", // Replace with your product ID
                    name = planName,
                    description = "Your plan description",
                    status = "ACTIVE",
                    billing_cycles = new[]
                    {
                    new
                    {
                        frequency = new
                        {
                            interval_unit = planFrequency,
                            interval_count = int.Parse(planFrequencyInterval)
                        },
                        tenure_type = planType,
                        sequence = 1,
                        total_cycles = int.Parse(planCycles),
                        pricing_scheme = new
                        {
                            fixed_price = new
                            {
                                value = planAmount.ToString("0.00"),
                                currency_code = planCurrency
                            }
                        }
                    }
                },
                    payment_preferences = new
                    {
                        auto_bill_outstanding = true,
                        setup_fee = new
                        {
                            value = "10.00", // Replace with your setup fee if needed
                            currency_code = planCurrency
                        },
                        setup_fee_failure_action = "CONTINUE",
                        payment_failure_threshold = 3
                    },
                    taxes = new
                    {
                        percentage = "10", // Replace with your tax percentage if needed
                        inclusive = false
                    }
                };

                var requestBodyJson = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);

                using (var content = new StringContent(requestBodyJson, Encoding.UTF8, "application/json"))
                {
                    content.Headers.Add("PayPal-Request-Id", "PLAN-18062019-001");
                    content.Headers.Add("Prefer", "return=representation");

                    var response = await httpClient.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        return $"HTTP Error {response.StatusCode}: {await response.Content.ReadAsStringAsync()}";
                    }
                }
            }
        }

    }
}