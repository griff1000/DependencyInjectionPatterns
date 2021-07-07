namespace DependencyInjectionPatterns.Unscoped
{
    using System;
    using Microsoft.Extensions.Logging;

    class AdvancedStuffDoer : BasicStuffDoer//, IDoStuff
    {
        private readonly ILogger<AdvancedStuffDoer> _logger;

        public AdvancedStuffDoer(ILogger<AdvancedStuffDoer> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public int DoSomethingWithNumber(int x)
        {
            var baseValue = base.DoSomethingWithNumber(x);
            _logger.LogInformation("Did something in AdvancedStuffDoer");
            return baseValue * 2;
        }




        #region other versions

        //public new int DoSomethingWithNumber(int x)
        //{
        //    var baseValue = base.DoSomethingWithNumber(x);
        //    _logger.LogInformation("Did something in AdvancedStuffDoer");
        //    return baseValue * 2;
        //}

        //public override int DoSomethingWithNumber(int x)
        //{
        //    var baseValue = base.DoSomethingWithNumber(x);
        //    _logger.LogInformation("Did something in AdvancedStuffDoer");
        //    return baseValue * 2;
        //}

        #endregion
    }
}
