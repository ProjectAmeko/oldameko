using System;
using System.Collections.Generic;
using Ameko.AssCS;

namespace Amebu
{
    public static class Amebu
    {
        private static readonly Dictionary<string, AssFile> TabRegistry = new Dictionary<string, AssFile>();

        /// <summary>
        /// Generates a UUID string for a tab to use.
        /// UUIDs are used to associate objects, like AssFiles,
        /// with a tab without having to worry about indexing.
        /// </summary>
        /// <returns>UUID</returns>
        private static string GenerateTabUuid()
            => Guid.NewGuid().ToString();

        /// <summary>
        /// Get the file associated with the tab UUID
        /// </summary>
        /// <param name="uuid">Tab UUID to look up</param>
        /// <returns>AssFile object associated with the tab UUID given</returns>
        /// <exception cref="AssException">Thrown when the tab does not exist</exception>
        public static AssFile GetAssFile(string uuid)
        {
            if (TabRegistry.ContainsKey(uuid)) return TabRegistry[uuid];
            throw new AssException($"Cannot get file for tab {uuid} as no such tab has been registered.");
        }

        /// <summary>
        /// Adds a tab to the registry
        /// </summary>
        /// <param name="file">AssFile used to create the tab</param>
        /// <returns>UUID for the new tab</returns>
        public static string RegisterTab(AssFile file)
        {
            var uuid = GenerateTabUuid();
            TabRegistry[uuid] = file;
            return uuid;
        }

        /// <summary>
        /// Removes a tab from the registry
        /// </summary>
        /// <param name="uuid">UUID of the tab to remove</param>
        /// <returns>True if the tab was successfully removed</returns>
        /// <exception cref="AssException">Thrown when the tab does not exist</exception>
        public static bool DeregisterTab(string uuid)
        {
            if (TabRegistry.ContainsKey(uuid)) return TabRegistry.Remove(uuid);
            throw new AssException($"Cannot deregister tab as tab {uuid} does not exist.");
        }
    }
}