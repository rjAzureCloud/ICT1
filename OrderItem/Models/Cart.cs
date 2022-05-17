namespace OrderItem.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public int menuItemId { get; set; }
        

        public string Name { get; set; }
    }
}
