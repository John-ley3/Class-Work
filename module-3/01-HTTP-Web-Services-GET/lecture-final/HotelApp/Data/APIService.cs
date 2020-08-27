using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace HTTP_Web_Services_GET_lecture.Data
{
    public class APIService
    {
        private readonly string API_URL = "";
        private readonly RestClient client = new RestClient();

        public APIService(string api_url)
        {
            API_URL = api_url;
        }

        public List<Hotel> GetHotels()
        {
            // Call the hotels api
            RestRequest request = new RestRequest(API_URL + "hotels");
            // Process the json into objects
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);
            // Return a list of hotels
            if(CheckResponse(response))
            {
                return response.Data;
            }
            return null;
        }

        public List<Review> GetReviews()
        {
            RestRequest request = new RestRequest(API_URL + "reviews");
            IRestResponse<List<Review>> response = client.Get<List<Review>>(request);
            if (CheckResponse(response))
            {
                return response.Data;
            }
            return null;
        }

        public Hotel GetDetailsForHotel(int hotelID)
        {
            RestRequest request = new RestRequest(API_URL + "hotels/" + hotelID);
            IRestResponse<Hotel> response = client.Get<Hotel>(request);
            if (CheckResponse(response))
            {
                return response.Data;
            }
            else
            {
                return null;
            }

        }

        public List<Review> GetReviewsForHotel(int hotelID)
        {
            RestRequest request = new RestRequest(API_URL + "hotels/" + hotelID + "/reviews");
            IRestResponse<List<Review>> response = client.Get<List<Review>>(request);
            if (CheckResponse(response))
            {
                return response.Data;
            }
            else
            {
                return null;
            }
        }

        public List<Hotel> GetHotelsWithStarRating(int stars)
        {
            RestRequest request = new RestRequest(API_URL + "hotels");
            request.AddParameter("stars", stars);
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);
            if (CheckResponse(response))
            {
                return response.Data;
            }
            return null;
        }

        public City GetPublicAPIQuery()
        {
            RestRequest request = new RestRequest("https://api.teleport.org/api/cities/geonameid:5206379");
            IRestResponse<City> response = client.Get<City>(request);
            if (CheckResponse(response))
            {
                return response.Data;
            }

            return null;
        }

        private bool CheckResponse(IRestResponse response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Hey, an error occurred. Couldn't talk to the server.");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Hmmm, the server doesn't like our request, try again.");
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
