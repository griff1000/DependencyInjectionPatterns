namespace DependencyInjectionPatterns.Capability
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Just a demo implementation of a class that consumes a collection of IDoStuffWithCapability implementations
    /// </summary>
    class SomethingThatUsesStuffDoers : IUseDoStuff
    {
        private IEnumerable<IDoStuffWithCapability> _stuffDoers;

        /// <summary>
        /// Constructor that takes a collection of IDoStuffWithCapability implementations
        /// </summary>
        public SomethingThatUsesStuffDoers(IEnumerable<IDoStuffWithCapability> stuffDoers)
        {
            _stuffDoers = stuffDoers ?? throw new ArgumentNullException(nameof(stuffDoers));
        }

        public void UseDoStuff(int x)
        {
            foreach (var stuffDoer in _stuffDoers)
            {
                // In this case the consuming class checks whether the implementation can handle the data, but you could just as easily get the implementing class to do that check and remove this if statement if that makes sense in your context
                if (stuffDoer.CanHandle(x))
                {
                    Console.WriteLine(stuffDoer.DoSomethingWithNumber(x));
                }
            }
        }
    }
}
