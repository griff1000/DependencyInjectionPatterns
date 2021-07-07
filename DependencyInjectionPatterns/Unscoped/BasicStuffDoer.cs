namespace DependencyInjectionPatterns.Unscoped
{
    /// <summary>
    /// Base class for IDoStuff for unscoped demos
    /// </summary>
    class BasicStuffDoer : IDoStuff
    {
        /// <summary>
        /// Often you start with a class not originally intended to be a base class so its members aren't virtual
        /// </summary>
        public int DoSomethingWithNumber(int x)
        {
            return x + 1;
        }



        #region another version
        ///// <summary>
        ///// If you want to override this method you need to make it virtual
        ///// </summary>
        //public virtual int DoSomethingWithNumber(int x)
        //{
        //    return x + 1;
        //}
        #endregion
    }
}
