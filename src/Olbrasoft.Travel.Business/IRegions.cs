﻿using Olbrasoft.Travel.Data.Transfer.Object;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Business
{
    public interface IRegions
    {
        Task<IEnumerable<ContinentItem>> GetContinentsAsync(int languageId,
            CancellationToken cancellationToken = default(CancellationToken));
        
        Task<IEnumerable<CountryItem>> GetCountriesAsync(int languageId,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<IEnumerable<CountryItem>> GetCountriesAsync(int continentId, int languageId,
            CancellationToken cancellationToken = default(CancellationToken));
    }

}