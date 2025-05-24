using System;
using System.Linq;
using FinServices_Dashboard.Models;

namespace FinServices_Dashboard.Pages
{
    public partial class RechargeHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadRechargeHistory();
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            LoadRechargeHistory();
        }

        private void LoadRechargeHistory()
        {
            using (var context = new RechargeContext())
            {
                var query = context.Recharges.AsQueryable();

                // Operator filter
                if (!string.IsNullOrEmpty(ddlOperator.SelectedValue))
                {
                    query = query.Where(r => r.Operator == ddlOperator.SelectedValue);
                }

                // From date filter
                if (DateTime.TryParse(txtFromDate.Text, out DateTime fromDate))
                {
                    query = query.Where(r => r.RechargedAt >= fromDate);
                }

                // To date filter
                if (DateTime.TryParse(txtToDate.Text, out DateTime toDate))
                {
                    query = query.Where(r => r.RechargedAt <= toDate);
                }

                gvHistory.DataSource = query.OrderByDescending(r => r.RechargedAt).ToList();
                gvHistory.DataBind();
            }
        }
    }
}
