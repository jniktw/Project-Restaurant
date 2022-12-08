using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Restaurant_System.DataAcessLayer.Models
{

    public class Table
    {
        [Key]
        public int IdTable { get; set; }

        public int IdRestaurant { get; set; }

        public int IdRoom { get; set; }

        public int NumberOfSeats { get; set; }

        public bool IsReserved { get; set; }


        public Table(int idRestaurant, int idRoom, int numberOfSeats, bool isReserved)
        {
            IdRestaurant = idRestaurant;
            IdRoom = idRoom;
            NumberOfSeats = numberOfSeats;
            IsReserved = isReserved;
        }
    }
}
