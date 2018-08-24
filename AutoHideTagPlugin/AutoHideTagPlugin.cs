using Smod2;
using Smod2.Attributes;
using Smod2.EventHandlers;
using Smod2.Events;

namespace AutoHideTagPlugin
{
    [PluginDetails(
        author = "lunax",
        name = "AutoHideTag",
        description = "Automatically Hiding Tag for your Role",
        id = "lunax.autohidetag",
        version = "1.0",
        SmodMajor = 3,
        SmodMinor = 1,
        SmodRevision = 13
    )]
    
    class AutoHideTagPlugin : Plugin
    {
        
        public static AutoHideTagPlugin plugin;
        
        public override void Register()
        {
            
            this.AddConfig(new Smod2.Config.ConfigSetting("autohidetag_roles", new string[] {string.Empty}, Smod2.Config.SettingType.LIST, true, "Roles to auto hide tags"));
            this.AddEventHandler(typeof(IEventHandlerPlayerJoin), new RoundEventHandler(this), Priority.Normal);
        }

        public override void OnEnable()
        {
            plugin = this;
            this.Info(this.Details.name + " v." + this.Details.version + " - Enabled");    
        }

        public override void OnDisable()
        {
            this.Info(this.Details.name + " v." + this.Details.version + " - Disabled");
        }
    }
}