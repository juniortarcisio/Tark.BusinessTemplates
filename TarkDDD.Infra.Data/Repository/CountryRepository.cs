using TarkDDD.Domain.Entities;
using TarkDDD.Domain.Interfaces.Repositories;
using TarkDDD.Infra.Data.Repository;

namespace TarkDDD.Infra.Data.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {

        public CountryRepository(TarkOrm.TarkOrm tarkOrm) 
            : base(tarkOrm)
        {
        }
    }
}
