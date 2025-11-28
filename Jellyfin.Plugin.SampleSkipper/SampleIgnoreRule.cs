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
            // If it's a directory, we generally don't ignore it unless the directory itself is named sample
            // But usually samples are files inside a folder. 
            
            if (fileInfo.IsDirectory)
            {
                // Optional: Uncomment below if you want to ignore entire folders named "Sample"
                // return fileInfo.Name.Contains("sample", StringComparison.OrdinalIgnoreCase);
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
