﻿using AdventureWorks.Core.Mappers.People;
using AdventureWorks.Core.Mappers.Sales;
using AutoMapper;

namespace AdventureWorks.Core.Mappers
{
    public sealed class MapperConfig
    {
        private static readonly MapperConfig Instance = new MapperConfig();

        private MapperConfig()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<CustomersMapProfile>();
                cfg.AddProfile<PeopleMapProfile>();
            });
        }

        public static MapperConfig InitializeInstanceMapping()
        {
            return Instance;
        }

    }
}
