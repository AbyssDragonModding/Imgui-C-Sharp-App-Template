# Imgui-C-Sharp-App-Template
Based off the video from Sweeds C#: https://youtu.be/5yVpcJo_jjs?si=R4CsNZ4RTE-dQmhk

With some fixes I noticed it having and some minor code changes like adding a MainWindow class to handle the window and variables instead of in the renderer and some cpu optimizations.

## Dependecies
- ClickableTransparentOverlay - 11.0.1
- ImGui.NET - 1.91.0.1
- Newtonsoft.Json - 13.0.3 (kinda forgot to remove it, but its a pretty common file type so Ill just keep it in)
  
## Changelog
#### Version 1.0.0 - Oct 30, 2024
- Update: ClickableTransparentOverlay now uses the latest version as of creation of the template
- Update: Latest Imgui.net version

- Added: MainWindow.cs class to handle the menu and its variables
- Added: DLL import for "user32.dll" to use the method "GetSystemMetrics()" to handle automatically setting the resolution of the ClickableTransparentOverlay

- Fix: Imgui menus now properly change variables and do not reset after you enter values 
- Fix: ClickableTransparentOverlay now properly scales to your monitor resolution automatically like the old versions used to do
