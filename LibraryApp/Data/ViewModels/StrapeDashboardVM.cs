using Stripe;
using System.Collections.Generic;

namespace LibraryApp.Data.ViewModels
{
    public class StrapeDashboardVM
    {
        public Balance Balance { get; set; }
        public List<BalanceTransaction> Transaction { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Charge> Charges { get; set; }

        public List<Dispute> Disputes { get; set; }
        public List<Refund> Refunds { get; set; }
        public List<Product> Products { get; set; }
    }
}
