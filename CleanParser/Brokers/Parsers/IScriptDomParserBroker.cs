// -------------------------------------------------------------------------------------------
// Copyright (c) The Standard Community, a coalition of the Good-Hearted Engineers
// -------------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace CleanParser.Brokers.Parsers
{
    public interface IScriptDomParserBroker
    {
        string ParseQuery(string queryText, out IList<ParseError> parseErrors);
    }
}