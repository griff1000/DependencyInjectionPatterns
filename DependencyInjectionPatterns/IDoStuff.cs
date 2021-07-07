namespace DependencyInjectionPatterns
{
    /// <summary>
    /// Base IDoStuff from which all other IDoStuffXXX interfaces inherit
    /// </summary>
    interface IDoStuff
    {
        int DoSomethingWithNumber(int x);
    }
}
