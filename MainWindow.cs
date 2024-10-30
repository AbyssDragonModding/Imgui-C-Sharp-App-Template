using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using ImGuiNET;

namespace ImGuiApp
{
    // Self contained Main Window for ImGui,
    // feel free to use this as a template to add new windows to the application
    public class MainWindow
    {
        private bool isOpen {  get; set; }
        private string windowName { get; set; }

        // Menu variables

        // Constructor
        public MainWindow() 
        { 
            windowName = "Imgui App Template";
        }
        // Set the window show state, if its set to false on the instance the menu will not show
        public void setWindowOpenState(bool isWindowOpenState)
        {
            isOpen = isWindowOpenState;
        }
        public void Show()
        {
            if (isOpen)
            {
                // Begin coding the menu
                ImGui.Begin(windowName);
                // Change the default window size so its not tiny
                ImGui.SetWindowSize(new Vector2(800, 400));

                // Additional widgets go here
                ImGui.End();
            }
        }


    }
}
