using ImGuiNET;
using System.Numerics;
using System.Runtime.InteropServices;
using ClickableTransparentOverlay;
using ImGuiApp;

namespace ImGuiApp
{
    public class Renderer : Overlay
    {
        // Overlay Variables
        static string overlayTitle = "Imgui Template App";


        // Import User32 DLL to get system Metrics
        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int nIndex);
        static int screenWidth = GetSystemMetrics(0); //Get width
        static int screenHeight = GetSystemMetrics(1); // Get Height
        
        // Create a main window INstance
        private MainWindow mainWindow;
        
        // Arg 1: Overlay Window Name
        // Arg 2: Window Width
        // Arg 3: Window Height
        public Renderer() : base(overlayTitle, screenWidth, screenHeight) 
        {
            mainWindow = new MainWindow();
            mainWindow.setWindowOpenState(true);
        }
        protected override void Render()
        {
            // Load the main window class
            mainWindow.Show();
        }
    }
}
