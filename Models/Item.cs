using System;
using System.Collections.Generic;

namespace HomeGadgets.Models
{
    public partial class Item
    {
        public Item()
        {
            PurchaseHistories = new HashSet<PurchaseHistory>();
        }

        public Guid Id { get; set; }
        public string ItemName { get; set; } = null!;
        public int Quantity { get; set; }
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<PurchaseHistory> PurchaseHistories { get; set; }
    }
}
