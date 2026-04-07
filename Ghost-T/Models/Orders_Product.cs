using System.ComponentModel.DataAnnotations;

namespace Ghost_T.Models
{
    public class Orders_Product
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}