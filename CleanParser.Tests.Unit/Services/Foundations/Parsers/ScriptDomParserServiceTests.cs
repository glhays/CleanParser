// -------------------------------------------------------------------------------------------
// Copyright (c) The Standard Community, a coalition of the Good-Hearted Engineers
// -------------------------------------------------------------------------------------------

using CleanParser.Brokers.Parsers;
using CleanParser.Services.Foundations;
using Moq;
using Tynamix.ObjectFiller;

namespace CleanParser.Tests.Unit.Services.Foundations.Parsers
{
    public partial class ScriptDomParserServiceTests
    {
        private readonly Mock<IScriptDomParserBroker> scriptDomParserBrokerMock;
        private readonly IScriptDomParserService scriptDomParserService;

        public ScriptDomParserServiceTests()
        {
            this.scriptDomParserBrokerMock = new Mock<IScriptDomParserBroker>();
            this.scriptDomParserService = new ScriptDomParserService(scriptDomParserBrokerMock.Object);
        }

        private static string GetRandomQueryString() =>
            new MnemonicString().GetValue();

        private static string GetRandomDomParsedQuery() =>
            new MnemonicString().GetValue();
    }
}