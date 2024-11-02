using System;
using System.Numerics;
using ImGuiNET;

namespace ImGuiApp
{
    public class ImguiWindow
    {
        // Class Variables
        private bool isOpen { get; set; }
        private string menuTitle { get; set; }
        private Vector2 menuDimensions { get; set; }
        private ImGuiWindowFlags flags { get; set; }

        // Constructor
        public ImguiWindow(string menuName, Vector2 menuSize, bool isMenuOpen = true, ImGuiWindowFlags windowFlags = ImGuiWindowFlags.NoCollapse)
        {
            isOpen = isMenuOpen;
            menuTitle = menuName;
            menuDimensions = menuSize;
            flags = windowFlags;
        }
        public void Render()
        {
            if (isOpen)
            {
                try
                {
                    ImGui.SetWindowSize(menuDimensions);
                    ImGui.Begin(menuTitle, flags);
                    Widgets();
                    ImGui.End();
                }
                
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.GetType()} - {e.Message}");
                }
            }
        }

        // Class methods
        protected virtual void Widgets()
        {
            ImGui.Text("Example Widget");
        }
    }
}
