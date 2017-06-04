using System;
using TarkOrm.Mapping;
using TarkOrm.Attributes;
using TarkDDD.Domain.Entities;

namespace TarkDDD.Infra.RepositoryTark.Mapping
{
    public class CountryMapping : IEntityMapping
    {
        public void Map()
        {
            TarkConfigurationMapping.AutoMapType<Country>()
                .MapProperty(x => x.CountryId, new KeyAttribute())
                .ToTable("MyPortal","dbo","Country");
        }
    }
}
