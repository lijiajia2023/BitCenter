using System;
using System.Collections.Generic;
using System.Text;

namespace BitCenter
{
    /// <summary>
    /// This is the plugin Manager. Plugins may use it to find other plugins and to load more plugins.
    /// </summary>
    public interface IPluginManager
    {
        /// <summary>
        /// Returns a list of loaded plugin GUIDs
        /// </summary>
        /// <returns>Plugin GUID list, empty array in case of none (not null)</returns>
        public string[] getGUID();

        /// <summary>
        /// Searches for a plugin with specified GUID
        /// </summary>
        /// <param name="GUID">GUID to search</param>
        /// <returns>IPlugin, or null if not found</returns>
        public IPlugin getPlugin(string GUID);

        /// <summary>
        /// Returns all loaded Plugins
        /// </summary>
        /// <returns>List of loaded Plugin, empty if none found (not null)</returns>
        public IPlugin[] getPlugin();

        /// <summary>
        /// Loads a compiled Plugin (.DLL)
        /// </summary>
        /// <param name="Path">DLL Path and Name</param>
        /// <returns>true, if successfully loaded</returns>
        public bool loadAssembly(string Path);

        /// <summary>
        /// Loads a single plugin from one or multiple source files
        /// </summary>
        /// <param name="Files">At least one file path and name</param>
        /// <returns>true, if the plugin has been loaded</returns>
        public bool loadCode(string[] Files);
    }
}
