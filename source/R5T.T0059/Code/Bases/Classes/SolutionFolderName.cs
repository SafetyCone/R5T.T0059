using System;


namespace R5T.T0059
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SolutionFolderName : ISolutionFolderName
    {
        #region Static
        
        public static SolutionFolderName Instance { get; } = new();

        #endregion
    }
}