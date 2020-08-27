using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private string connectionString;

        /// <summary>
        /// Creates a sql based country dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CountrySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public IList<Country> GetCountries()
        {
            IList<Country> countries = new List<Country>();

            try
            {
                // TODO 01 Create the connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // TODO 02 Open Connection
                    connection.Open();
                    // TODO 03
                    SqlCommand sqlCommand = new SqlCommand();
                    // TODO 04 Create command text
                    string sqlStatement = "select * from country";
                    // TODO 05 Set command text to command
                    sqlCommand.CommandText = sqlStatement;
                    // TODO 06 Set Connection
                    sqlCommand.Connection = connection;
                    // TODO 07 Read data
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    // Read each row
                    while (reader.Read())
                    {
                        Country country = new Country();
                        country.Code = Convert.ToString(reader["code"]);
                        country.Name = Convert.ToString(reader["name"]);
                        country.Continent = Convert.ToString(reader["continent"]);
                        country.Region = Convert.ToString(reader["region"]);
                        country.SurfaceArea = Convert.ToDouble(reader["surfacearea"]);
                        country.Population = Convert.ToInt32(reader["population"]);
                        country.GovernmentForm = Convert.ToString(reader["governmentform"]);
                        countries.Add(country);
                    }
                    // TODO 08 Close the connection via the using statement
                }
            }
            catch (Exception e)
            {

            }
            return countries;
        }

        public IList<Country> GetCountries(string continent)
        {
            IList<Country> countries = new List<Country>();

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlCommandString = "select * from country where continent = @continent";

                    SqlCommand cmd = new SqlCommand(sqlCommandString, conn);
                    cmd.Parameters.AddWithValue("@continent", continent);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Country country = ConvertReaderToCountry(reader);
                        countries.Add(country);
                    }
                }
            } catch(Exception e)
            {

            }
            return countries;
        }

        private Country ConvertReaderToCountry(SqlDataReader readerIn)
        {
            Country output = new Country();
            output.Code = Convert.ToString(readerIn["code"]);
            output.Name = Convert.ToString(readerIn["name"]);
            output.Continent = Convert.ToString(readerIn["continent"]);
            output.Region = Convert.ToString(readerIn["region"]);
            output.SurfaceArea = Convert.ToDouble(readerIn["surfacearea"]);
            output.Population = Convert.ToInt32(readerIn["population"]);
            output.GovernmentForm = Convert.ToString(readerIn["governmentform"]);
            return output;
        }
    }
}
