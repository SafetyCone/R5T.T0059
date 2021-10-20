using System;

using R5T.T0059;
using R5T.T0059.X001;


namespace System
{
    public static class ISolutionFolderNameExtensions
    {
        public static string Dependencies(this ISolutionFolderName _)
        {
            return SolutionFolderNames.Dependencies;
        }
    }
}