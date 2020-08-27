using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservations.Models
{
    public class Reservation
    {
        public int? Id { get; set; }
        [Required]
        public int HotelID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required(ErrorMessage ="Please, oh please, provide a check in date")]
        public string CheckinDate { get; set; }
        [Required]
        public string CheckoutDate { get; set; }
        [Range(1,6,ErrorMessage ="The minimum number of guests is 1 and maximum is 6.")]
        public int Guests { get; set; }

        public Reservation(int? id, int hotelId, string fullName, string checkinDate, string checkoutDate, int guests)
        {
            Id = id ?? new Random().Next(100, int.MaxValue);
            HotelID = hotelId;
            FullName = fullName;
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
            Guests = guests;
        }
    }
}
