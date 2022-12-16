using System.ComponentModel.DataAnnotations;

namespace Restaurant_System.DataAcessLayer.Models;

public class Reservation
{
    [Key]
    public int ReservationId { get; set; }
    public DateTime ReservationDate { get; set; }
    
    public Table Table { get; set; }

    public Reservation(DateTime reservationDate)
    {
        ReservationDate = reservationDate;
    }
    
}