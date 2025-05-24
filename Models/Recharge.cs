using System;

namespace FinServices_Dashboard.Models
{
    public class Recharge
    {
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public string Operator { get; set; }
        public decimal Amount { get; set; }
        public DateTime RechargedAt { get; set; }
    }
}
