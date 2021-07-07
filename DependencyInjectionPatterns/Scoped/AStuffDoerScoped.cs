namespace DependencyInjectionPatterns.Scoped
{
    /// <summary>
    /// An implementation of IDoStuffScoped
    /// </summary>
    class AStuffDoerScoped<TScope> : IDoStuffScoped<TScope>
    {
        public int DoSomethingWithNumber(int x)
        {
            return x + 1;
        }
    }
}
