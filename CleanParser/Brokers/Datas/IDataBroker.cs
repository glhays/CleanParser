// ---------------------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ---------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanParser.Brokers.Datas
{
    internal partial interface IDataBroker
    {
        ValueTask<IEnumerable<T>> ExecuteQueryAsync<T>(string query);
    }
}