using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.SampleSkipper
{
    public class Plugin : BasePlugin
    {
        public override Guid Id => Guid.Parse("5826df63-32c0-4822-9218-403d67f5370d");

        public override string Name => "Sample Skipper";

        public override string Description => "Ignores video files with the word 'sample' in the filename.";

        public static Plugin Instance { get; private set; }

        // FIX: In Jellyfin 10.11.3, BasePlugin likely has a parameterless constructor.
        // We pass no arguments to base(), but we can still keep dependencies in our constructor for future use.
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) 
            : base() 
        {
            Instance = this;
        }
    }
}
