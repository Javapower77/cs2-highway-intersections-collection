using Colossal;
using Game.Modding;
using Game.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionsCollection
{
    public partial class ModSettings : ModSetting
    {
        public class LocaleEN : IDictionarySource
        {
            private readonly ModSettings _setting;
            private Dictionary<string, string> _translations;

            public LocaleEN(ModSettings setting)
            {
                _setting = setting;
                _translations = Load();
            }
            public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
            {
                return _translations;
            }

            public static string GetToolTooltipLocaleID(string tool, string value)
            {
                return $"{Mod.MOD_NAME}.Tooltip.Tools[{tool}][{value}]";
            }

            public static string GetLanguageNameLocaleID()
            {
                return $"{Mod.MOD_NAME}.Language.DisplayName";
            }

            public Dictionary<string, string> Load(bool dumpTranslations = false)
            {
                return new Dictionary<string, string>
                {
                    { _setting.GetSettingsLocaleID(), "Industries Extended" },
                    { GetLanguageNameLocaleID(), "English"},
                    { _setting.GetOptionTabLocaleID(ModSettings.AboutTab), "About" },
                    // Groups
                    { _setting.GetOptionGroupLocaleID(ModSettings.AboutSection), "Mod Info" },
                    //Keybindings

                    //Labels
                    { _setting.GetOptionLabelLocaleID(nameof(ModSettings.OpenRepositoryAtVersion)), "Open GitHub mod repository" },
                    { _setting.GetOptionDescLocaleID(nameof(ModSettings.OpenRepositoryAtVersion)), "Open the github repository of this mod." },
                    { _setting.GetOptionLabelLocaleID(nameof(ModSettings.OpenRepositoryRoadmap)), "Open Roadmap" },
                    { _setting.GetOptionDescLocaleID(nameof(ModSettings.OpenRepositoryRoadmap)), "Open the status board of the tasks involved in the developing of this mod." },
                    { _setting.GetOptionLabelLocaleID(nameof(ModSettings.ModVersion)), "Version" },
                    { _setting.GetOptionDescLocaleID(nameof(ModSettings.ModVersion)), "Mod current version." },
                    { _setting.GetOptionLabelLocaleID(nameof(ModSettings.AuthorMod)), "Mod author" },
                    { _setting.GetOptionDescLocaleID(nameof(ModSettings.AuthorMod)), "Name of the author of this mod." },
                    { _setting.GetOptionLabelLocaleID(nameof(ModSettings.InformationalVersion)), "Informational Version" },
                    { _setting.GetOptionDescLocaleID(nameof(ModSettings.InformationalVersion)), "Mod version with the commit ID from GitHub." },
                    { _setting.GetOptionLabelLocaleID(nameof(ModSettings.DiscordServers)), "Discord Servers" },
                    { _setting.GetOptionLabelLocaleID(nameof(ModSettings.OpenCS2ModdingDiscord)), "Cities: Skylines Modding Discord" },
                    { _setting.GetOptionDescLocaleID(nameof(ModSettings.OpenCS2ModdingDiscord)), "Open the official Cities Skyline 2 modding discord server." },
                    { _setting.GetOptionLabelLocaleID(nameof(ModSettings.OpenAuthorDiscord)), "Mod Author Server" },
                    { _setting.GetOptionDescLocaleID(nameof(ModSettings.OpenAuthorDiscord)), "Open the author discord server." },
                    // Buttons
                };
            }

            public void Unload() { }

            public override string ToString()
            {
                return "IntersectionsCollection.Locale.en-US";
            }
        }
    }
}
