// -------------------------------------------------------------------------------------------
// Copyright (c) The Standard Community, a coalition of the Good-Hearted Engineers
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace CleanParser.Brokers.Parsers
{
    public class ScriptDomParser : IScriptDomParser
    {
        private readonly TSql150Parser parser;

        public ScriptDomParser() => 
            this.parser = new TSql150Parser(false);
        
        public string ParseQuery(string queryText, out IList<ParseError> parseErrors)
        {
            using var reader = new StringReader(queryText);
            var queryResult = parser.Parse(reader, out parseErrors);
            parseErrors = null;

            return queryResult.ToString();
        }
    }
}