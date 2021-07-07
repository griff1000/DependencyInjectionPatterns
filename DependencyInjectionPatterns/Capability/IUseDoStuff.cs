namespace DependencyInjectionPatterns.Capability
{
    /// <summary>
    /// Just a demo interface for a class that consumes the IDoStuffWithCapability implentations
    /// </summary>
    interface IUseDoStuff
    {
        void UseDoStuff(int x);
    }
}
