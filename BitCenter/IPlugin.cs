using System.Windows.Forms;

namespace BitCenter
{
    /// <summary>
    /// Informations about a plugin
    /// </summary>
    public class PluginInfo
    {
        /// <summary>
        /// Any string you want. Each plugin must have its unique string.
        /// You should not change this in updated versions of your plugin,
        /// as this allows you to prevent users from loading your plugin twice.
        /// </summary>
        public string GUID;

        /// <summary>
        /// The human readable name of the plugin.
        /// </summary>
        public string Name;
        
        /// <summary>
        /// Plugin version
        /// </summary>
        public string Version;
        
        /// <summary>
        /// Description of the plugin
        /// </summary>
        public string Description;
        
        /// <summary>
        /// Plugin author
        /// </summary>
        public string Author;
        
        /// <summary>
        /// true, if this plugin has a config window.
        /// </summary>
        public bool Config;
    }

    /// <summary>
    /// A Message
    /// </summary>
    public class Message
    {
        /// <summary>
        /// The from address.
        /// </summary>
        public string from;
        
        /// <summary>
        /// The destination address.
        /// </summary>
        public string to;
        
        /// <summary>
        /// Message content
        /// </summary>
        public string content;

        /// <summary>
        /// ID of Destination 
        /// </summary>
        public string destination;
        public bool moreProcessing;
        public bool delete;
    }



    /// <summary>
    /// Plugin interface.
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// This is called when initializing your plugin
        /// </summary>
        /// <param name="f">The MDI container form, in case this is null, the application runs in a terminal</param>
        void Init(Form f);

        /// <summary>
        /// Returns Plugin informations
        /// </summary>
        /// <returns>Plugin informations</returns>
        PluginInfo Info();

        /// <summary>
        /// Calls for the configuration window. This may be called while the window is already shown
        /// if the user clicks the menu option again. Only called, if Info().Config is true.
        /// </summary>
        void Config();

        /// <summary>
        /// This is called, when the Application wants to exit.
        /// After 5 seconds, the user has the ability to forcefully terminate your plugin.
        /// </summary>
        void OnExit();

        /// <summary>
        /// Executed whan a message arrives
        /// </summary>
        /// <param name="m">message</param>
        /// <returns>message (may be modified by this function or null, if the message is to be discarded.</returns>
        Message OnMessage(Message m);

        /// <summary>
        /// A plugin was added to the system.
        /// </summary>
        /// <param name="GUID">Plugin identifier</param>
        void OnPluginAdded(string GUID);
    }
}
