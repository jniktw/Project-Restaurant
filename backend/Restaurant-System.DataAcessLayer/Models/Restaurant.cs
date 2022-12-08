namespace Restaurant_System.DataAcessLayer.Models
{
    public class Restaurant
    {
        public Restaurant(string name, string city, string address)
        {
            Name = name;
            City = city;
            Address = address;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        
    }
}