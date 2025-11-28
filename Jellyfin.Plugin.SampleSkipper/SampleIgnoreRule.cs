using System;
using MediaBrowser.Controller.Resolvers;
using MediaBrowser.Model.IO;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.SampleSkipper
{
    public class SampleIgnoreRule : IResolverIgnoreRule
    {
        private readonly ILogger<SampleIgnoreRule> _logger;

        public SampleIgnoreRule(ILogger<SampleIgnoreRule> logger)
        {
            _logger = logger;
        }

        public bool ShouldIgnore(FileSystemMetadata fileInfo, string parentPath)
        {
            // Könyvtárakat alapból nem hagyunk ki, hacsak nem akarod
            if (fileInfo.IsDirectory)
            {
                return false;
            }

            // Ellenőrzi, hogy a fájlnév tartalmazza-e a "sample" szót (kis/nagybetű nem számít)
            if (fileInfo.Name.Contains("sample", StringComparison.OrdinalIgnoreCase))
            {
                _logger.LogInformation($"[SampleSkipper] Fájl kihagyása: {fileInfo.FullName}");
                return true;
            }

            return false;
        }
    }
}
