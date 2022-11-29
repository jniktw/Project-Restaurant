namespace Restaurant_System.DataAcessLayer.Models
{
    public class Restaurant
    {
        int Id;

        string Name;

        string City;

        string Address;

        public Restaurant(int id, string name, string city, string address)
        {
            Id = id;
            Name = name;
            City = city;
            Address = address;
        }
    }
}