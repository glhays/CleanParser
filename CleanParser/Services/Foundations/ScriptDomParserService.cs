// -------------------------------------------------------------------------------------------
// Copyright (c) The Standard Community, a coalition of the Good-Hearted Engineers
// -------------------------------------------------------------------------------------------

using CleanParser.Brokers.Parsers;

namespace CleanParser.Services.Foundations
{
    public class ScriptDomParserService : IScriptDomParserService
    {
        private readonly IScriptDomParserBroker scriptDomParserBroker;

        public ScriptDomParserService(IScriptDomParserBroker scriptDomParserBroker) =>
            this.scriptDomParserBroker = scriptDomParserBroker;

        public string RetrieveParsedQuery(string query)
        {
            throw new System.NotImplementedException();
        }
    }
}