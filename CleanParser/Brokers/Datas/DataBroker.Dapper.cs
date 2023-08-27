// ---------------------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ---------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace CleanParser.Brokers.Datas
{
    internal partial class DataBroker
    {
        public async ValueTask<IEnumerable<T>> RetrieveDataAsync<T>(string query)
        {
            using var connection = new SqlConnection(this.configuration.ConnectionString);

            return await connection.QueryAsync<T>(query);
        }
    }
}