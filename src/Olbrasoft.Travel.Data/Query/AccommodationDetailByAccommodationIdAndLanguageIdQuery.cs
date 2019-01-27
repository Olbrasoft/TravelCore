﻿using Olbrasoft.Data.Queries;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Query
{
    public class AccommodationDetailByAccommodationIdAndLanguageIdQuery : ByAccommodationIdAndLanguageIdQuery<AccommodationDetail>
    {
        public AccommodationDetailByAccommodationIdAndLanguageIdQuery(IProvider queryProvider) : base(queryProvider)
        {
        }
    }
}