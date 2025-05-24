using System.Collections.Generic;
using System.Data.Entity;

namespace FinServices_Dashboard.Models
{
    public class RechargeContext : DbContext
    {
        public RechargeContext() : base("name=RechargeDB1") { }

        public DbSet<Recharge> Recharges { get; set; }
    }
}
