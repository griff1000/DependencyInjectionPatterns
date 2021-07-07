namespace DependencyInjectionPatterns.Scoped
{
    /// <summary>
    /// Adds ability to give a scoping type parameter to IDoStuff, allowing a consumer to pick a specific registered IDoStuff from a collection of IDoStuff registrations
    /// </summary>
    interface IDoStuffScoped<TScope> : IDoStuff
    {
    }
}
