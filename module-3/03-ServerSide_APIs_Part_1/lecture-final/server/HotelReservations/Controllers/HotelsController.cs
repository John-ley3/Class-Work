using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private static IHotelDao _hotelDao;
        private static IReservationDao _reservationDao;

        public HotelsController()
        {
            _hotelDao = new HotelDao();
            _reservationDao = new ReservationDao();
        }

        [HttpGet("hotels")]
        public List<Hotel> ListHotels()
        {
            return _hotelDao.List();
        }

        [HttpGet("hotels/{id}")]
        public Hotel GetHotel(int id)
        {
            Hotel hotel = _hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }

            return null;
        }

        [HttpGet("reservations")]
        public List<Reservation> ListReservations()
        {
            return _reservationDao.List();
        }

        [HttpGet("reservations/{rid}")]
        public Reservation GetReservation(int rid)
        {
            Reservation reservation = _reservationDao.Get(rid);
            if (reservation != null)
            {
                return reservation;
            }
            return null;
        }

        [HttpGet("hotels/{hotelid}/reservations")]
        public List<Reservation> GetReservationsByHotelId(int hotelid)
        {
            List<Reservation> reservations = _reservationDao.FindByHotel(hotelid);
            if (reservations != null)
            {
                return reservations;
            }
            return null;
        }

        [HttpPut("reservations/{id}")]
        public Reservation UpdateReservation(int id, Reservation reservation)
        {
            Reservation currentReservation = _reservationDao.Get(id);
            if (currentReservation == null)
            {
                return null;
            }
            currentReservation.HotelID = reservation.HotelID;
            currentReservation.CheckinDate = reservation.CheckinDate;
            currentReservation.CheckoutDate = reservation.CheckoutDate;
            // can't change name
            currentReservation.Guests = reservation.Guests;
            return _reservationDao.Update(currentReservation);
        }
        [HttpPost("reservations")]
        public Reservation AddReservation(Reservation reservation)
        {
            return _reservationDao.Create(reservation);
        }

        [HttpGet("hotels/filter")]
        public List<Hotel> FilterByCityAndState(string city, string state)
        {
            List<Hotel> hotelsFound = new List<Hotel>();
            List<Hotel> allHotels = _hotelDao.List();

            foreach (Hotel item in allHotels)
            {
                if (city != null)
                {
                    if (item.Address.City.ToLower().Equals(city.ToLower()))
                    {
                        hotelsFound.Add(item);
                    }
                }
                else if (state != null)
                {
                    if (item.Address.State.ToLower().Equals(state.ToLower()))
                    {
                        hotelsFound.Add(item);
                    }

                }
            }

            return hotelsFound;
        }
    }
}
