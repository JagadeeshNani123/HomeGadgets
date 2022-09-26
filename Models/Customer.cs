using System;
using System.Collections.Generic;

namespace HomeGadgets.Models
{
    public partial class Customer
    {
        public Customer()
        {
            PurchaseHistories = new HashSet<PurchaseHistory>();
        }

        public Guid Id { get; set; }
        public string EmailAddress { get; set; } = null!;
        public byte[] Password { get; set; } = null!;
        public string Address { get; set; } = null!;

        public virtual ICollection<PurchaseHistory> PurchaseHistories { get; set; }
    }
}
