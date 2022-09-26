using System;
using System.Collections.Generic;

namespace HomeGadgets.Models
{
    public partial class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
            PurchaseHistories = new HashSet<PurchaseHistory>();
        }

        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<PurchaseHistory> PurchaseHistories { get; set; }
    }
}
