using System;
using System.Collections.Generic;

namespace HomeGadgets.Models
{
    public partial class PurchaseHistory
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public int ItemCount { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public Guid CategoryId { get; set; }
        public Guid CustomerId { get; set; }
        public string? PurchaseMode { get; set; }
        public string? PurchaseDetails { get; set; }
        public bool IsCartItem { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual Item Item { get; set; } = null!;
    }
}
