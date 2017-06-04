using System.Collections.Generic;

namespace TarkDDD.Infra.RepositoryTark.Mapping
{
    public static class MappingConfig
    {
        public static List<IEntityMapping> Mappings { get; set; } = new List<IEntityMapping>();

        public static void Add(IEntityMapping mapping)
        {
            mapping.Map();
            Mappings.Add(mapping);
        }

        public static void RegisterMappings()
        {
            Add(new CountryMapping());
        }
    }
}
