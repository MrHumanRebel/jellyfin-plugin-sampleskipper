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
            // We usually don't want to skip directories, unless specified
            if (fileInfo.IsDirectory)
            {
                return false;
            }

            // Check if the filename contains "sample" (Case Insensitive)
            if (fileInfo.Name.Contains("sample", StringComparison.OrdinalIgnoreCase))
            {
                _logger.LogInformation($"[SampleSkipper] Ignoring file: {fileInfo.FullName}");
                return true;
            }

            return false;
        }
    }
}
