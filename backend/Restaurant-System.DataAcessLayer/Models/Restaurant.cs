namespace Restaurant_System.DataAcessLayer.Models
{
    public class Restaurant
    {
        int Id { get; set; }
        string Name { get; set; }
        string City { get; set; }
        string Address { get; set; }
        ICollection<Table> Tables { get; set; }
        public Restaurant(string name, string city, string address, ICollection<Table> tables)
        {
            Name = name;
            City = city;
            Address = address;
            Tables = tables;
        }
    }
}