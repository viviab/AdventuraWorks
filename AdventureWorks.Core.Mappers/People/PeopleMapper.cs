﻿using AdventureWorks.Core.Entities.EF;
using AdventureWorks.UI.ViewEntities.People;
using AutoMapper;

namespace AdventureWorks.Core.Mappers
{
    public static class PeopleMapper 
    {
        public static Person MapTo(PersonRequest person)
        {
            return Mapper.Map<PersonRequest, Person>(person);
        }
    }
}
