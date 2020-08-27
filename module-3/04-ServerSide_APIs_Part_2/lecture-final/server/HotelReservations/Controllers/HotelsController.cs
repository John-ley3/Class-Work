using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;
using RestSharp;

namespace HotelReservations.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private static IHotelDao _hotelDao;
        private static IReservationDao _reservationDao;

        public HotelsController(IHotelDao hotelDao, IReservationDao reservationDao)
        {
            _hotelDao = hotelDao;
            _reservationDao = reservationDao;
        }

        [HttpGet("hotels")]
        public List<Hotel> ListHotels()
        {
            return _hotelDao.List();
        }

        [HttpGet("hotels/{id}")]
        public ActionResult<Hotel> GetHotel(int id)
        {
            Hotel hotel = _hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("hotels/filter")]
        public List<Hotel> FilterByStateAndCity(string state, string city)
        {
            List<Hotel> filteredHotels = new List<Hotel>();

            List<Hotel> hotels = ListHotels();
            // return hotels that match state
            foreach (Hotel hotel in hotels)
            {
                if (city != null)
                {
                    // if city was passed we don't care about the state filter
                    if (hotel.Address.City.ToLower().Equals(city.ToLower()))
                    {
                        filteredHotels.Add(hotel);
                    }
                }
                else
                {
                    if (hotel.Address.State.ToLower().Equals(state.ToLower()))
                    {
                        filteredHotels.Add(hotel);
                    }
                }
            }
            return filteredHotels;
        }

        [HttpGet("reservations")]
        public List<Reservation> ListReservations()
        {
            return _reservationDao.List();
        }

        [HttpGet("reservations/{id}")]
        public ActionResult<Reservation> GetReservation(int id)
        {
            Reservation reservation = _reservationDao.Get(id);

            if (reservation != null)
            {
                return reservation;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("hotels/{hotelId}/reservations")]
        public ActionResult<List<Reservation>> ListReservationsByHotel(int hotelId)
        {
            Hotel hotel = _hotelDao.Get(hotelId);
            if (hotel == null)
            {
                return NotFound("Hotel Id is invalid");
            }
            return _reservationDao.FindByHotel(hotelId);
        }

        [HttpPost("reservations")]
        public ActionResult<Reservation> AddReservation(Reservation reservation)
        {
            Reservation added = _reservationDao.Create(reservation);
            return Created($"/api/reservations/{added.Id}", added);
        }

        [HttpPut("reservations/{id}")]
        public ActionResult<Reservation> UpdateReservation(int id, Reservation reservationToUpdate)
        {
            Reservation existingReservation = _reservationDao.Get(reservationToUpdate.Id.Value);
            if(existingReservation == null)
            {
                return NotFound("Reservation doesn't exist. Try again?");
            }
            // If here, we know the reservation exists
            Reservation result = _reservationDao.Update(reservationToUpdate.Id.Value,reservationToUpdate);
            return Ok(result);
        }

        [HttpDelete("reservations/{id}")]
        public ActionResult DeleteReservation(int id)
        {
            Reservation existingReservation = _reservationDao.Get(id);
            if (existingReservation == null)
            {
                return NotFound("Reservation doesn't exist. Try again?");
            }
            bool didDelete = _reservationDao.Delete(id);
            if (didDelete)
            {
                return NoContent();
            }
            return StatusCode(500);
        }

        [HttpGet("city")]
        public ActionResult GetCity(int geonameid)
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest("https://api.teleport.org/api/cities/geonameid:" + geonameid);
            IRestResponse<City> response = client.Get<City>(request);
            if (response.ResponseStatus != ResponseStatus.Completed || !response.IsSuccessful)
            {
                return NotFound();
            }
            else
            {
                return Ok(response.Data);
            }
        }

    }
}