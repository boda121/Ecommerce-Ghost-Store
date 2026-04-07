using System.ComponentModel.DataAnnotations;

namespace Ghost_T.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string CartId { get; set; }
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}