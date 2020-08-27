using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace WorldGeographyTests
{
    [TestClass]
    public class LanguageSqlDAOTests : WorldTestInitialize
    {
        [TestMethod]
        public void GetLanguageByCountryCode()
        {
            // Arrange
            LanguageSqlDAO languageSqlDAO = new LanguageSqlDAO(connectionString);
            // Act
            IList<Language> languages = languageSqlDAO.GetLanguages(countryCodeToTest);
            // Assert
            Assert.IsTrue(languages.Count > 0);
        }

        [TestMethod]
        public void AddLanguageTest()
        {
            // Arrange
            LanguageSqlDAO languageSqlDAO = new LanguageSqlDAO(connectionString);
            Language language = new Language
            {
                CountryCode = countryCodeToTest,
                Name = "Klingon",
                IsOfficial = true,
                Percentage = 5
            };
            // Act
            bool didItWork = languageSqlDAO.AddNewLanguage(language);
            // Assert
            Assert.IsTrue(didItWork);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguageDuplicateTest()
        {
            // Arrange
            LanguageSqlDAO languageSqlDAO = new LanguageSqlDAO(connectionString);
            Language language = new Language
            {
                CountryCode = countryCodeToTest,
                Name = languageToTest,
                IsOfficial = true,
                Percentage = 5
            };
            // Act
            bool didItWork = languageSqlDAO.AddNewLanguage(language);
            // Assert
            Assert.IsFalse(didItWork);

        }
    }
}
