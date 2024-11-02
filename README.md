# Imgui-C-Sharp-App-Template
Based off the video from Sweeds C#: https://youtu.be/5yVpcJo_jjs?si=R4CsNZ4RTE-dQmhk

With some bug fixes I noticed that needed to be fixed, and having and some minor code changes like adding a MainWindow class to handle the window and variables instead of in the renderer and some cpu optimizations.

License: MIT

## Diferences from the video setup
- Created a MainWindow.cs to handle the menu varibles/widgets instead of directly in the renderer
- Uses the latest ClickableTransparentOverlay version with a fix that fixes the overlay not using your proper screen resolution thanks to a dll import automatically getting your screen size and setting it to the overlay constructor subclas paramaters.
- Fixed the menus resetting values thanks to the way the MainWindow.cs is set up and rendered (from memory the way he had it setup in the video they kept resetting variables and it would never take in the new values)
- Changed program.cs to include a actual class and main function like regular C# code should be as well as some more threading logic to only use the cpu when its needed/requested (although small it lowers cpu usage overall)

## Dependecies - 1.0.0
- ClickableTransparentOverlay - 11.0.1
- ImGui.NET - 1.91.0.1

## Installation 
Download the archive under releases and Copy/Move it to your Visual studio documents Ex: "Documents/Visual Studio 2022/Templates/ProjectTemplates" you can also extract the archive into "Documents/Visual Studio 2022/Templates/ProjectTemplates/C#" (not sure if this one is actually needed havent tested it)

## Usage
 - Once you setup your project open up the "MainWindow.cs"
 - Take a look at how its restructured (changed from 1.0.0)
 - To create new windows you can now subclass the ImguiWindow class and in your constructor put "base()" with the paramaters you want in the prenthisis, and then override the Widgets Method to add widgets to the window
 - No support for custom title bars (you will have to do that rendering yourself and will need to override the ImguiWindow.Renderer() method to do so)

## Changelog
#### Version 1.0.0 - Oct 30, 2024
- Update: ClickableTransparentOverlay now uses the latest version as of creation of the template
- Update: Latest Imgui.net version

- Added: MainWindow.cs class to handle the menu and its variables
- Added: DLL import for "user32.dll" to use the method "GetSystemMetrics()" to handle automatically setting the resolution of the ClickableTransparentOverlay

- Fix: Imgui menus now properly change variables and do not reset after you enter values 
- Fix: ClickableTransparentOverlay now properly scales to your monitor resolution automatically like the old versions used to do

### Version 1.1.0 - Nov 2, 2024
- Added ImguiWindow class
- Updated MainWindow Example to use the new ImguiWindow class
- Updated Renderer.cs for the new changes to the MainWindow Class
- Updated SLN and CSProj to their latest
