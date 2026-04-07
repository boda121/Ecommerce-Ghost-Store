using MyEcommerceAdmin.Models;
using System.ComponentModel.DataAnnotations;

namespace Ghost_T.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<bool> isActive { get; set; }

     //   public virtual ICollection<genPromoRight> genPromoRights { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
