using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplatesForBusiness.Domain.Entities;

namespace TemplatesForBusiness.Tests.Validations
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
