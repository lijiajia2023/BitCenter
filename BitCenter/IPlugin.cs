using System.Windows.Forms;

namespace BitCenter
{
    /// <summary>
    /// Fired, whenever a gate/plugin outputs a message after processing
    /// </summary>
    /// <param name="m">message</param>
    public delegate void SetMessageHandler(Message m);

    /// <summary>
    /// Informations about a plugin
    /// </summary>
    public class PluginInfo
    {
        /// <summary>
        /// Various Plugin types
        /// </summary>
        public enum PluginType
        {
            /// <summary>
            /// Unknown plugin, if set to this value, the plugin is invisible and unusable.
            /// </summary>
            Unknown=0,
            /// <summary>
            /// Regular plugin, cannot be start or end of chain.
            /// </summary>
            Plugin=1,
            /// <summary>
            /// Gate, can only be start or end of chain
            /// </summary>
            Gate=2
        }

        /// <summary>
        /// Each plugin must have its unique string.
        /// You should not change this in updated versions of your plugin,
        /// as this allows you to prevent users from loading your plugin twice.
        /// see guid.txt
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

        /// <summary>
        /// Shows, if the plugin supports multiple instances.
        /// </summary>
        public bool MultiInstance;

        /// <summary>
        /// true, if the plugin accepts multiple inputs
        /// </summary>
        public bool MultiIn;

        /// <summary>
        /// true, if the plugin accepts multiple outputs
        /// </summary>
        public bool MultiOut;

        /// <summary>
        /// Type of Plugin
        /// </summary>
        public PluginType Type;
    }

    /// <summary>
    /// A Message
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Duplicates the message including the ID.
        /// </summary>
        /// <returns></returns>
        public Message Dupe()
        {
            Message m = (Message)MemberwiseClone();
            return m;
        }

        public Message()
        {
            ID = PluginManager.NextID();
        }

        /// <summary>
        /// The from address.
        /// </summary>
        public string from
        { get; set; }
        
        /// <summary>
        /// The destination address.
        /// </summary>
        public string to
        { get; set; }

        /// <summary>
        /// Message subject
        /// </summary>
        public string subject
        { get; set; }

        /// <summary>
        /// Message content
        /// </summary>
        public string content
        { get; set; }

        /// <summary>
        /// The Gate, that generated the Message
        /// </summary>
        public IPlugin source
        { get; set; }

        /// <summary>
        /// defaults to true, if set to false, this message will not pass more filters.
        /// Should generally not be set to false except for some exclusive cases
        /// (for example Message is forcefully needed "AS IS")
        /// </summary>
        public bool moreProcessing
        { get; set; }

        /// <summary>
        /// Defaults to false. If this is true, the message can control the
        /// operation of some gates and plugins
        /// </summary>
        public bool isServiceMsg
        { get; set; }

        /// <summary>
        /// Returns the runtime ID of the message.
        /// Do not relay on these. If the Application is restarted,
        /// the ID restarts at 0.
        /// </summary>
        public ulong ID
        {get;private set;}
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
        /// <returns>true, if loaded, false on error</returns>
        bool Init(Form f);

        /// <summary>
        /// Loads a second instance of a plugin
        /// </summary>
        /// <param name="f">Main Form</param>
        /// <param name="ID">Plugin Number</param>
        /// <returns>true, if loaded, false if not supported or error</returns>
        bool Init(Form f, int ID);

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
        /// Sets new plugins, that input data. Overwrites existing settings
        /// </summary>
        /// <param name="p">Plugins</param>
        void setPluginInput(Plugin[] p);
        /// <summary>
        /// Sets new plugins, that receive processed data. Overwrites existing settings
        /// </summary>
        /// <param name="p">Plugins</param>
        void setPluginOutput(Plugin[] p);

        /// <summary>
        /// Returns all input plugins
        /// </summary>
        /// <returns></returns>
        Plugin[] getPluginInput();
        /// <summary>
        /// Returns all output plugins
        /// </summary>
        /// <returns></returns>
        Plugin[] getPluginOutput();

        void SetMessage(Message m);

        event SetMessageHandler GetMessage;

        /// <summary>
        /// A plugin was added to the system.
        /// </summary>
        /// <param name="GUID">Plugin identifier</param>
        void OnPluginAdded(string GUID);
    }
}
