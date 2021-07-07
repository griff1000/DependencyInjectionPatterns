namespace DependencyInjectionPatterns.Scoped
{
    /// <summary>
    /// Another implementation of IDoStuffScoped
    /// </summary>
    class AnotherStuffDoerScoped<TScope> : IDoStuffScoped<TScope>
    {
        public int DoSomethingWithNumber(int x)
        {
            return x * 2;
        }
    }
}
