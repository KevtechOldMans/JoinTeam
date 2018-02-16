using Rocket.API;
using Rocket.Core.Commands;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace RulesPlugin
{
    public class Rules : RocketPlugin<Config>
    {
        protected override void Load()
        {
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
        }
        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
        }
        private void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            UnturnedChat.Say(player, "Schreibe /rules um die Regeln zu sehen.", UnityEngine.Color.cyan);
        }
        [RocketCommand("rules", "Benutze /rules", "rules", AllowedCaller.Both)]
        public void ExecuteRulesCommand(IRocketPlayer caller, string[] args)
        {
            if (args.Length == 0)
            {
                UnturnedChat.Say(caller, "Die Regeln", GetColor1());
                UnturnedChat.Say(caller, "1.Kein RDM", GetColor2());
                UnturnedChat.Say(caller, "2.Kein VDM", GetColor2());
                UnturnedChat.Say(caller, "3.Kein Bodyloot", GetColor2());
                UnturnedChat.Say(caller, "4.Nicht Beleidigen, ausser im RP", GetColor2());
                UnturnedChat.Say(caller, "5.Keine Raidwaffen", GetColor2());
                UnturnedChat.Say(caller, "6.Kein Raiden", GetColor2());
            }
        }
        [RocketCommand("rule1", "Benutze /rule1", "rule1", AllowedCaller.Both)]
        public void ExecuteRule1Command(IRocketPlayer caller, string[] args)
        {
            if (args.Length == 0)
            {
                UnturnedChat.Say(caller, "Regel 1", GetColor1());
                UnturnedChat.Say(caller, "Unter RDM zählt, dass man ohne ankündigung einen Spieler tötet.", GetColor2());
                UnturnedChat.Say(caller, "Bestrafung: 1 Verwarnung", GetColor2());
            }
        }
        [RocketCommand("rule2", "Benutze /rule2", "rule2", AllowedCaller.Both)]
        public void ExecuteRule2Command(IRocketPlayer caller, string[] args)
        {
            if (args.Length == 0)
            {
                UnturnedChat.Say(caller, "Regel 2", GetColor1());
                UnturnedChat.Say(caller, "Unter VDM zählt, dass man einen Spieler mit einem Fahrzeug tötet.", GetColor2());
                UnturnedChat.Say(caller, "Bestrafung: 1 Verwarnung", GetColor2());
            }
        }
        [RocketCommand("rule3", "Benutze /rule3", "rule3", AllowedCaller.Both)]
        public void ExecuteRule3Command(IRocketPlayer caller, string[] args)
        {
            if (args.Length == 0)
            {
                UnturnedChat.Say(caller, "Regel 3", GetColor1());
                UnturnedChat.Say(caller, " Unter Bodyloot zählt, dass man die Items von einem gestorbenen oder getöteten Spieler aufsammelt.", GetColor2());
                UnturnedChat.Say(caller, "Bestrafung: 1 Verwarnung", GetColor2());
            }
        }
        [RocketCommand("rule4", "Benutze /rule4", "rule4", AllowedCaller.Both)]
        public void ExecuteRule4Command(IRocketPlayer caller, string[] args)
        {
            if (args.Length == 0)
            {
                UnturnedChat.Say(caller, "Regel 4", GetColor1());
                UnturnedChat.Say(caller, "", GetColor2());
                UnturnedChat.Say(caller, "Bestrafung: 1 Verwarnung", GetColor2());
            }
        }
        [RocketCommand("rule5", "Benutze /rule5", "rule5", AllowedCaller.Both)]
        public void ExecuteRule5Command(IRocketPlayer caller, string[] args)
        {
            if (args.Length == 0)
            {
                UnturnedChat.Say(caller, "Regel 5", GetColor1());
                UnturnedChat.Say(caller, "", GetColor2());
                UnturnedChat.Say(caller, "Bestrafung:", GetColor2());
            }
        }
        [RocketCommand("rule6", "Benutze /rule6", "rule6", AllowedCaller.Both)]
        public void ExecuteRule6Command(IRocketPlayer caller, string[] args)
        {
            if (args.Length == 0)
            {
                UnturnedChat.Say(caller, "Regel 6", GetColor1());
                UnturnedChat.Say(caller, "", GetColor2());
                UnturnedChat.Say(caller, "Bestrafung:", GetColor2());
            }
        }
        public void Say(IRocketPlayer caller, string msg)
        {
            if (caller is UnturnedPlayer)
            {
                UnturnedChat.Say(caller, msg, UnityEngine.Color.blue);
            }
            else
            {
                Rocket.Core.Logging.Logger.Log(msg);
            }
        }
        public Color GetColor1()
        {
            string colorName = Configuration.Instance.RegelÜberschriften;
            return UnturnedChat.GetColorFromName(colorName, Color.red);
        }

        public Color GetColor2()
        {
            string colorName = Configuration.Instance.Regeln;
            return UnturnedChat.GetColorFromName(colorName, Color.red);
        }
    }
}
