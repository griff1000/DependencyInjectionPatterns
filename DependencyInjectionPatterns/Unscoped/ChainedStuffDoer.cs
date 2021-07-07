namespace DependencyInjectionPatterns.Unscoped
{
    using System;
    using DependencyInjectionPatterns;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Uses the Decorator pattern to chain implementations of IDoStuff together, just calling the next one in the chain and then "decorating" the output of that with its own implementation
    /// </summary>
    class ChainedStuffDoer : IDoStuff
    {
        private readonly IDoStuff _nextStuffDoer;
        private readonly ILogger<ChainedStuffDoer> _logger;

        /// <summary>
        /// Constructor taking in the next IDoStuff implementation to call  potentially either before, during or after this class's implementation
        /// </summary>
        /// <param name="nextStuffDoer">The next IDoStuff implementation in the decorator chain</param>
        public ChainedStuffDoer(IDoStuff nextStuffDoer, ILogger<ChainedStuffDoer> logger)
        {
            _nextStuffDoer = nextStuffDoer ?? throw new ArgumentNullException(nameof(nextStuffDoer));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Calls the next IDoStuff implementation in the chain then decorates the output of that with its own implementation
        /// </summary>
        public int DoSomethingWithNumber(int x)
        {
            var intermediateResult = _nextStuffDoer.DoSomethingWithNumber(x);
            _logger.LogInformation("Did something in ChainedStuffDoer");
            return intermediateResult * 2;
        }
    }
}
