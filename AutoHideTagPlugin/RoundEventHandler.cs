using System.Linq;
using Smod2;
using Smod2.EventHandlers;
using Smod2.Events;
namespace AutoHideTagPlugin
{
    class RoundEventHandler :  IEventHandlerPlayerJoin
    {
        private Plugin plugin;
        
        public RoundEventHandler(Plugin plugin)
        {
            this.plugin = plugin;
        }

        public void OnPlayerJoin(PlayerJoinEvent ev)
        {
            var l = this.plugin.GetConfigList("autohidetag_roles");
            var l2 = l.Select(t => t.Trim()).ToList();
            if (l2.Contains(ev.Player.GetRankName().ToLower()))
                ev.Player.HideTag(true);
        }
    }
}