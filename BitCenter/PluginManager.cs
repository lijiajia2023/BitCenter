using System;
using System.Collections.Generic;
using System.Text;

namespace BitCenter
{
    /// <summary>
    /// This is the plugin Manager. Plugins may use it to find other plugins and to load more plugins.
    /// </summary>
    public class PluginManager
    {
        /// <summary>
        /// Returns a list of loaded plugin GUIDs
        /// </summary>
        /// <returns>Plugin GUID list, empty array in case of none (not null)</returns>
        public string[] GUID
        {
            get
            {
                return new string[] { };
            }
        }

        /// <summary>
        /// Searches for a plugin with specified GUID
        /// </summary>
        /// <param name="GUID">GUID to search</param>
        /// <returns>IPlugin, or null if not found</returns>
        public IPlugin getPlugin(string GUID)
        {
            return null;
        }

        /// <summary>
        /// Returns all loaded Plugins
        /// </summary>
        /// <returns>List of loaded Plugin, empty if none found (not null)</returns>
        public IPlugin[] AllPlugins
        {
            get
            {
                return new IPlugin[] { };
            }
        }

        /// <summary>
        /// Adds an already existing Plugin. Ideal,
        /// in case you want to have a plugin running multiple times,
        /// provided it can dynamically adjust its GUID
        /// </summary>
        /// <param name="p">Plugin</param>
        /// <returns>true, if added, false if already existing</returns>
        public bool addPlugin(IPlugin p)
        {
            return false;
        }

        /// <summary>
        /// Loads a compiled Plugin (.DLL)
        /// </summary>
        /// <param name="Path">DLL Path and Name</param>
        /// <returns>true, if successfully loaded</returns>
        public bool loadAssembly(string Path)
        {
            return false;
        }

        /// <summary>
        /// Loads a single plugin from one or multiple source files
        /// </summary>
        /// <param name="Files">At least one file path and name</param>
        /// <returns>true, if the plugin has been loaded</returns>
        public bool loadCode(string[] Files)
        {
            return false;
        }
    }
}
