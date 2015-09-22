# WallpaperChanger
Change the desktop background based on running processes.

## Instructions
  1. Download WallpaperChanger.zip from the [latest released version](https://github.com/LenAnderson/WallpaperChanger/releases/latest)
  1. Unzip the archive
  1. Put your wallpapers into the "wallpaper" folder.
    - Supported file types: jpg, png, bmp, gif
    - To use a single wallpaper for a process call it *processname*.jpg (e.g. "calc.exe.jpg")
    - To use multiple wallpapers for a process (one will be selected at random when you start the process) create a folder with the process' name and add your wallpapers to that folder (e.g. "calc.exe/mywallpaper1.jpg", "calc.exe/mywallpaper2.jpg", ...)
    - Add a wallpaper named "default.jpg" (or a folder "default"). This will be set as the wallpaper when a process stops.
    - If you add wallpapers after starting the program you can use the "Rescan" button to index the new files.
  1. Start WallpaperChanger.exe (must run with admin privileges to detect starting and stopping of processes)
    - You can minimize the application window to the system tray.
    - Closing the window will exit the application.
