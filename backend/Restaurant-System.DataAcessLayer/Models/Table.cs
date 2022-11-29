using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_System.DataAcessLayer.Models
{
    public class Table
    {
        int Id;

        int NumberOfTable;

        int NumberOfSits;

        public ICollection<Restaurant> Restaurants;

        public Table(int numberOfTable, int numberOfSits, ICollection<Restaurant> restaurants)
        {
            NumberOfTable = numberOfTable;
            NumberOfSits = numberOfSits;
            Restaurants = restaurants;
        }
    }
}
