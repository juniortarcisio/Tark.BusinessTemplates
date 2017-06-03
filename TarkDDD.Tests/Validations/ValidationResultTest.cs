using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TarkDDD.Domain.Entities;

namespace TarkDDD.Tests.Validations
{
    [TestClass]
    public class ValidationResultTest
    {
        [TestMethod]
        public void TestValidationResult1()
        {
            Country country = new Country();

            country.Name = "teste";
            country.CountryCode = "ABC";
            country.CountryId = 1;

            var result = country.Validate();

            Assert.IsTrue(result.IsValid == false && result.Errors.Count == 1);


        }
    }
}
