using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace WorldGeographyTests
{
    [TestClass]
    public class CitySqlDAOTests : WorldTestInitialize
    {
        
        [TestMethod]
        public void GetCitiesByCountryCodeTest()
        {
            // Arrange
            CitySqlDAO citySqlDAO = new CitySqlDAO(connectionString);
            // Act
            IList<City> cities = citySqlDAO.GetCitiesByCountryCode("USA");
            // Assert
            Assert.IsTrue(cities.Count > 0);
        }

    }
}
