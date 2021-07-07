namespace DependencyInjectionPatterns.Capability
{
    /// <summary>
    /// Adds the ability for an implementing class to decide if it can handle the data given to it
    /// </summary>
    interface IDoStuffWithCapability : IDoStuff
    {
        bool CanHandle(int number);
    }
}
