﻿using Olbrasoft.Data.Querying;
using Olbrasoft.Travel.Data.Queries.Accommodation;

namespace Olbrasoft.Travel.Data.Unit.Tests.Queries.Accommodation
{
    internal class AwesomeByRealEstateIdAndLanguageIdQuery : ByRealEstateIdAndLanguageIdQuery<object>
    {
        public AwesomeByRealEstateIdAndLanguageIdQuery(IQueryDispatcher queryDispatcher) : base(queryDispatcher)
        {
        }
    }
}