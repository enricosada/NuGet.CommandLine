﻿using System.Resources;

namespace NuGet.CommandLine
{
    internal class NuGetCommandResourceType
    {
        private static readonly ResourceManager resourceMan = new ResourceManager("NuGet.CommandLine.NuGetCommandResourceType", typeof(NuGetCommandResourceType).Assembly);

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        internal static ResourceManager ResourceManager
        {
            get
            {
                return resourceMan;
            }
        }
    }
}
