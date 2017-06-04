using Microsoft.VisualStudio.TestTools.UnitTesting;
using TarkDDD.Domain.Entities;
using TarkDDD.Domain.Services;
using TarkDDD.Infra.Data.Repository;

namespace TarkDDD.Tests.Domain
{
    [TestClass]
    public class CountryTest
    {
        CountryService _countryService;

        public CountryTest()
        {
            TarkOrm.TarkOrm tarkOrm = new TarkOrm.TarkOrm("localhost");
            _countryService = new CountryService(new CountryRepository(tarkOrm));
        }

        [TestMethod]
        public void CountryTest_Add()
        {
            Country country = new Country();

            //if (_countryService.ExistsById(248))
            //    return;

            country.Name = "teste 2";
            country.CountryCode = "AB";
            country.CountryId = 249;
            country.ContinentID = 2;

            var validationResult =  _countryService.Add(country);

           // var result = country.Validate();

            // Assert.IsTrue(result.IsValid == false && result.Errors.Count == 1);
        }
    }
}
