using Scarab.Enums;
using System.IO;

namespace Scarab.Interfaces
{
    public interface ISettings
    {
        AutoRemoveUnusedDepsOptions AutoRemoveUnusedDeps { get; set; }
        bool WarnBeforeRemovingDependents { get; set; }
        bool UseCustomModlinks { get; set; }
        string CustomModlinksUri { get; set; }
        string BaseLink { get; set; }
        SupportedLanguages? PreferredLanguage { get; set; }
        bool CacheDownloads { get; set; }
        string CacheSpaceTaken { get; }

        string ManagedFolder { get; set; }
        string AlternateManagedFolder { get; set; }
        string CacheFolder { get; }

        bool RequiresWorkaroundClient { get; set; }
        
        string ModsFolder     => Path.Combine(ManagedFolder, "Mods");
        string DisabledFolder => Path.Combine(ModsFolder, "Disabled");

        void Save();
    }
}