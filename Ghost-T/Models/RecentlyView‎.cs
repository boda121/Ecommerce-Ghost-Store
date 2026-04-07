using System.ComponentModel.DataAnnotations;

namespace Ghost_T.Models
{
    public class RecentlyView
    {
        
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public System.DateTime ViewDate { get; set; }
        public string Note { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}