using System;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Common.ApplicationHost;
using MediaBrowser.Common.Configuration;

namespace Jellyfin.Plugin.SampleSkipper
{
    public class Plugin : BasePlugin
    {
        // Egyedi azonosító a plugin számára
        public override Guid Id => Guid.Parse("a4f5d6e7-1b2c-4d3e-5f6g-7h8i9j0k1l2m");

        public override string Name => "Sample Skipper";

        public override string Description => "Figyelmen kívül hagyja a 'sample' szót tartalmazó videofájlokat.";

        public static Plugin Instance { get; private set; }

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) 
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }
    }
}
