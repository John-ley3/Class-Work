using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;

namespace WorldGeographyTests
{
    [TestClass]
    public class WorldTestInitialize
    {
        protected TransactionScope transactionScope;
        protected string connectionString = @"Data Source=.\SQLEXpress;Initial Catalog=World;Integrated Security=true";
        protected string countryCodeToTest = "YYZ";
        protected int testCityId = 0;
        protected string languageToTest = "Elvish";

        [TestInitialize]
        public void Initialize()
        {
            // Initialize my transaction scope
            transactionScope = new TransactionScope();

            // Get or put the data to test
            // Go through our 7 step program
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlSelect = $"Select count(*) from country where code = '{countryCodeToTest}'";
                SqlCommand cmd = new SqlCommand(sqlSelect, connection);
                int countryCount = Convert.ToInt32(cmd.ExecuteScalar());
                // If the countryCode exists, we're good. If not add it
                if (countryCount == 0)
                {
                    string sqlInsert = $"insert into country VALUES('{countryCodeToTest}','Tech Elevator','North America','United States',40,2015,42,112,1,1,'TE','Dictatorship','Jennifer',null,'TE')";
                    cmd = new SqlCommand(sqlInsert, connection);
                    cmd.ExecuteNonQuery();
                }

                // Hey, need to make sure there's at least one city associated with the country
                string sqlCityInsert = $"insert into city VALUES('Gotham City','{countryCodeToTest}','Pennsylvania',17);select scope_identity();";
                cmd = new SqlCommand(sqlCityInsert, connection);
                testCityId = Convert.ToInt32(cmd.ExecuteScalar());

                // Determine if the combination of code and language is there
                try
                {
                    string languageInsert = $"insert into countrylanguage VALUES('{countryCodeToTest}','{languageToTest}',0,2)";
                    cmd = new SqlCommand(languageInsert, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                }
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            transactionScope.Dispose();
        }

    }
}
