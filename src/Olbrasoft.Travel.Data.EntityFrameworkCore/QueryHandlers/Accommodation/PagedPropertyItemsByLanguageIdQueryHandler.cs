﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.Queries.Accommodation;
using Olbrasoft.Travel.Data.Transfer.Objects;
using Olbrasoft.Travel.Data.Transfer.Objects.Accommodation;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.QueryHandlers.Accommodation
{
    public class PagedPropertyItemsByLanguageIdQueryHandler : QueryHandler<PagedPropertyItemsTranslationQuery, Property,
        IResultWithTotalCount<PropertyItem>>
    {
        public override async Task<IResultWithTotalCount<PropertyItem>> HandleAsync(PagedPropertyItemsTranslationQuery query, CancellationToken token)
        {
            var localizedAccommodations = PreHandle(Source, query);
            var accommodationItems = ProjectTo<PropertyItem>(localizedAccommodations);

            var result = new ResultWithTotalCount<PropertyItem>
            {
                Result = await accommodationItems.Skip(query.Paging.CalculateSkip()).Take(query.Paging.PageSize).ToArrayAsync(token),

                TotalCount = await accommodationItems.CountAsync(token)
            };

            return result;
        }

        private static IQueryable<PropertyTranslation> PreHandle(IQueryable<Property> source, PagedPropertyItemsTranslationQuery query)
        {
            var localizedAccommodations = source.SelectMany(p => p.PropertiesTranslations);

            var localizedAccommodationQueryable = localizedAccommodations.Include(p => p.Property).Where(p => p.LanguageId == query.LanguageId);

            var localizedAccommodationOrderedQueryable = query.Sorting(localizedAccommodationQueryable);

            return localizedAccommodationOrderedQueryable;
        }

        public PagedPropertyItemsByLanguageIdQueryHandler(TravelDbContext context, IProjection projector) : base(context, projector)
        {
        }
    }
}