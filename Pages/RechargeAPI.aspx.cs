using FinServices_Dashboard.Logs;
using FinServices_Dashboard.Models;
using System;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;

namespace FinServices_Dashboard.Pages
{
    public partial class RechargeAPI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnRecharge_Click(object sender, EventArgs e)
        {
            string mobile = txtMobile.Text.Trim();
            string op = txtOperator.Text.Trim();
            string amt = txtAmount.Text.Trim();

            var requestData = new { MobileNumber = mobile, Operator = op, Amount = amt };
            string requestJson = new JavaScriptSerializer().Serialize(requestData);
            string responseJson = "";

            try
            {
                using (var client = new HttpClient())
                {
                    var content = new StringContent(requestJson, Encoding.UTF8, "application/json");
                    var response = client.PostAsync("https://jsonplaceholder.typicode.com/posts", content).Result;
                    responseJson = response.Content.ReadAsStringAsync().Result;
                }

                // Log the API request and response
                FinServices_Dashboard.Logs.APILogging.Log(requestJson, responseJson);

                // Save the recharge to DB
                using (var context = new RechargeContext())
                {
                    var recharge = new Recharge
                    {
                        MobileNumber = mobile,
                        Operator = op,
                        Amount = decimal.Parse(amt),
                        RechargedAt = DateTime.Now
                    };

                    context.Recharges.Add(recharge);
                    context.SaveChanges();
                }

                lblMessage.Text += "<br/>Recharge simulated successfully.";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblMessage.Text += "<br/>Error: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }


    }
}
