<div align="center">

# Jellyfin Sample Skipper

*A lightweight, automated plugin for Jellyfin that keeps your library clean.*

<p align="center">
  <img
    src="https://raw.githubusercontent.com/MrHumanRebel/jellyfin-plugin-sampleskipper/main/sampleskipper.png"
    alt="Sample Skipper Banner"
    width="200"
  />
</p>

</div>

---

## Overview

Sample Skipper is a small plugin that automatically detects and ignores **"sample" video files** during Jellyfin library scans.

If a file has `sample` in its name, the plugin prevents it from ever appearing in your Jellyfin library, avoiding clutter and manual cleanup.

---

## Features

- **Automatic detection** – Integrates with the Jellyfin library scanner and skips files containing `sample` in the filename.
- **Case-insensitive matching** – Detects `sample`, `Sample`, `SAMPLE`, and other case variations.
- **No configuration required** – Install and enable; no additional setup needed.
- **Lightweight** – Designed to have minimal impact on library scan performance.

Example filenames that will be ignored:

- `Pacific.Rim.2013.2160p...-Sample.mkv`
- `Some.Movie.1080p.BluRay.x264-SAMPLE.mp4`
- `Movie.Sample.avi`

---

## Installation

### Option 1: Repository (recommended)

1. Open your **Jellyfin Dashboard**.  
2. Navigate to **Plugins → Repositories**.  
3. Click **(+) Add Repository**.  
4. Enter the following details:

   - **Name:** `Sample Skipper Repo`  
   - **URL:**  
     `https://raw.githubusercontent.com/MrHumanRebel/jellyfin-plugin-sampleskipper/main/manifest.json`

5. Open the **Catalog** tab, find **Sample Skipper**, and click **Install**.  
6. **Restart Jellyfin** to load the plugin.

---

### Option 2: Manual installation

1. Download the latest `.zip` release from the **Releases** page.  
2. Extract the plugin files (DLL and manifest).  
3. Place them into your Jellyfin plugins folder:

   - **Linux:** `/var/lib/jellyfin/plugins/`  
   - **Windows:** `%ProgramData%\Jellyfin\Server\plugins\`

4. **Restart** the Jellyfin server.

---

## Building from source

### Requirements

- [.NET 9.0.10 SDK](https://dotnet.microsoft.com/)

### Steps

```bash
# Clone the repository
git clone https://github.com/MrHumanRebel/jellyfin-plugin-sampleskipper.git

# Enter the directory
cd jellyfin-plugin-sampleskipper

# Build the project
dotnet build Jellyfin.Plugin.SampleSkipper/Jellyfin.Plugin.SampleSkipper.csproj --configuration Release
