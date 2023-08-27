// ---------------------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ---------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using CleanParser.Models.Datas;

namespace CleanParser.Brokers.Datas
{
    internal partial class DataBroker
    {
        private readonly DataConfigurations configuration;

        public DataBroker(DataConfigurations configuration) =>
            this.configuration = configuration;

        public async ValueTask<IEnumerable<T>> ExecuteQueryAsync<T>(string query) =>
            await RetrieveDataAsync<T>(query);
    }
}