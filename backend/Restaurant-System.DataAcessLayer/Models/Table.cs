using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_System.DataAcessLayer.Models
{
    public class Table
    {
        public int IdTable { get; set; }

        public int IdRestaurant { get; set; }

        public int IdRoom { get; set; }

        public int NumberOfSits { get; set; }

        public bool IsReserved { get; set; }



        public Table(int idRestaurant, int idRoom, int numberOfSits, bool isReserved)
        {
            IdRestaurant = idRestaurant;
            IdRoom = idRoom;
            NumberOfSits = numberOfSits;
            IsReserved = isReserved;
        }
    }
}
