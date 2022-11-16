using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_System.DataAcessLayer.Models
{
    public class Product
    {
        public Product(int id, string productName, int actualNumber, int requiredNumber, string unit)
        {
            Id = id;
            ProductName = productName;
            ActualNumber = actualNumber;
            RequiredNumber = requiredNumber;
            Unit = unit;
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ActualNumber { get; set; }
        public int RequiredNumber { get; set; }
        public string Unit { get; set; }
    }
}
