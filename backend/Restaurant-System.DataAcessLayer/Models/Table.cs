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

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }


        public Table(int restaurantId,  int numberOfSeats, int reservationId)
        {
            RestaurantId = restaurantId;
            NumberOfSeats = numberOfSeats;
            ReservationId = reservationId;
        }
    }
}
