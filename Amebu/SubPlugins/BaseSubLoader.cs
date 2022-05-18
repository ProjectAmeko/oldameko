using Ameko.AssCS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amebu.SubPlugins
{
    public interface ISubLoader
    {
        /// <summary>
        /// Loads the subtitle file specified.
        /// </summary>
        /// <param name="path">A *hopefully* valid file</param>
        /// <param name="index">Index to determine which ass file to load.</param>
        /// <returns>An integer, indicating if the file has been loaded or not.</returns>
        public int LoadFile(string path, int index = -1);
        /// <summary>
        /// Returns the AssFile.
        /// </summary>
        /// <returns>Returns a AssFile, can be null.</returns>
        public AssFile? GetAssFile();
        public string[] FileExtensions { get; }
        /// <summary>
        /// Gets the error code returned by "LoadFile"
        /// </summary>
        /// <param name="errCode"></param>
        /// <returns></returns>
        public string GetErrorMessage(int errCode);
    }
}
