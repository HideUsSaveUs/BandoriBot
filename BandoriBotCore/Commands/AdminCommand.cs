using BandoriBot.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandoriBot.Commands
{
    public class AdminCommand : HashCommand<Admin>
    {
        protected override List<string> Alias => new List<string>
        {
            "/admin"
        };
        protected override void Run(CommandArgs args)
        {
            if (!args.IsAdmin) return;
            base.Run(args);
        }
    }
}
