namespace Ghost_T.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public string Type_Delivery { get; set; }
        public bool Status { get; set; } = false;
        public List<Order> Order_id { get; set; }
    }
}
