using System;
using MediaBrowser.Controller.Entities;
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

        public bool ShouldIgnore(FileSystemMetadata fileInfo, BaseItem parent)
        {
            if (fileInfo.IsDirectory)
            {
                return false;
            }

            if (fileInfo.Name.Contains("sample", StringComparison.OrdinalIgnoreCase))
            {
                _logger.LogInformation("[SampleSkipper] Ignoring file: {Path}", fileInfo.FullName);
                return true;
            }

            return false;
        }
    }
}
