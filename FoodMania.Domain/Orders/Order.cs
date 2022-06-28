
namespace FoodMania.Domain.Orders
{
    public class Order
    {

        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Product> OrderProducts { get; set; }
        public Address DeliveryAddress { get; set; }
    }

    public class Product
    {
        public Product(Guid id, int quantity)
        {

        }

        public Guid Id { get; set; }
        public int Quantity { get; set; }
    }

    public class Address
    {
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Complement { get; set; }
        public string State { get; set; }
    }
}
