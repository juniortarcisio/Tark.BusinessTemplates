using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarkDDD.Domain.Entities;
using TarkDDD.Domain.Interfaces.Repositories;

namespace TarkDDD.Domain.Services
{
    public class CountryService : Service<Country>
    {
        public CountryService(ICountryRepository repository) : base(repository)
        {
        }
    }
}
