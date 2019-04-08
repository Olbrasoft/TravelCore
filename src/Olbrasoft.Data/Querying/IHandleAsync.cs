﻿using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data.Querying
{
    public interface IHandleAsync<in TQuery, TResult> where TQuery : IQuery<TResult>
    {
         Task<TResult> HandleAsync(TQuery query);

        Task<TResult> HandleAsync(TQuery query, CancellationToken token);

    }
}