namespace DependencyInjectionPatterns.Capability
{
    using System;

    /// <summary>
    /// Another implementation of IDoStuffWithCapability
    /// </summary>
    class AnotherStuffDoerWithCapability : IDoStuffWithCapability
    {
        private Func<int, bool> _canHandleFunction;

        /// <summary>
        /// Constructor which takes a function which can be used to decide if this implementation can handle the data it's going to be given
        /// </summary>
        public AnotherStuffDoerWithCapability(Func<int, bool> canHandleFunction)
        {
            _canHandleFunction = canHandleFunction ?? throw new ArgumentNullException(nameof(canHandleFunction));
        }

        public bool CanHandle(int number)
        {
            // could just do something like : if (number >= 10) return true else return false 
            return _canHandleFunction.Invoke(number);
        }

        public int DoSomethingWithNumber(int x)
        {
            // It might make sense, depending on your context, to do the CanHandle check in here
            return x * 2;
        }
    }
}
