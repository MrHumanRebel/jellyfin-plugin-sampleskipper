<div align="center">

Jellyfin Sample Skipper

A lightweight, automated plugin for Jellyfin that keeps your library clean.

</div>

✨ Overview

Sample Skipper is a simple yet powerful plugin designed to automatically detect and ignore "sample" video files during library scans. No more manual cleanup or cluttered folders—if a file has "sample" in its name, this plugin ensures it never reaches your Jellyfin library.

🚀 Features

Automatic Detection: seamless integration with the Jellyfin library scanner.

Case Insensitive: detects sample, Sample, SAMPLE, or any variation.

Zero Config: install it and forget it; it works out of the box.

Lightweight: minimal impact on scan performance.

📦 Installation

Option 1: Official Repository (Recommended)

Open your Jellyfin Dashboard.

Navigate to Plugins -> Repositories.

Click (+) Add Repository.

Enter the following details:

Name: Sample Skipper Repo

URL: https://raw.githubusercontent.com/MrHumanRebel/jellyfin-plugin-sampleskipper/main/manifest.json

Go to the Catalog tab, find Sample Skipper, and click Install.

Restart Jellyfin to load the plugin.

Option 2: Manual Installation

Download the latest .zip release from the Releases Page.

Extract the Jellyfin.Plugin.SampleSkipper.dll file.

Place the file into your Jellyfin plugins folder (usually /var/lib/jellyfin/plugins/ on Linux or %ProgramData%\Jellyfin\Server\plugins\ on Windows).

Restart the Jellyfin server.

🛠️ Building from Source

Requirements:

.NET 9.0 SDK

# Clone the repository
git clone [https://github.com/MrHumanRebel/jellyfin-plugin-sampleskipper.git](https://github.com/MrHumanRebel/jellyfin-plugin-sampleskipper.git)

# Enter the directory
cd jellyfin-plugin-sampleskipper

# Build the project
dotnet build Jellyfin.Plugin.SampleSkipper/Jellyfin.Plugin.SampleSkipper.csproj --configuration Release


🤝 Contributing

Contributions, issues, and feature requests are welcome! Feel free to check the issues page.

📄 License

Distributed under the MIT License. See LICENSE for more information.

<div align="center">
<sub>Made with ❤️ for the Jellyfin Community</sub>
</div>
