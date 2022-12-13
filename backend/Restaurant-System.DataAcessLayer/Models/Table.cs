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
        public int TableId { get; set; }
        
        public int NumberOfSeats { get; set; }

        public bool IsReserved { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }


        public Table(int restaurantId, int numberOfSeats, bool isReserved)
        {
            RestaurantId = restaurantId;
            NumberOfSeats = numberOfSeats;
            IsReserved = isReserved;
        }
    }
}
