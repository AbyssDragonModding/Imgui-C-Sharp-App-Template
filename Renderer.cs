using System.Numerics;
using System.Runtime.InteropServices;
using ClickableTransparentOverlay;

namespace ImGuiApp
{
    internal class Renderer : Overlay
    {
        private MainWindow mainWindow;
        // Change this variable to change the overlay title text
        static string overlayTitle = "ImGui App Template";

        // use user32 DLL to get system metrics and the screen size of the monitor
        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(int nIndex);
        // Using System metrics get the width/height of the monitor and set it to the overlayDimensions vector
        static Vector2 overlayDimensions = new Vector2(GetSystemMetrics(0), GetSystemMetrics(1));

        public Renderer() : base(overlayTitle, (int)overlayDimensions[0], (int)overlayDimensions[1])
        {
            // Create the class instances for windows here
            mainWindow = new MainWindow();
        }

        // Renderer method
        protected override void Render()
        {
            // Load your class instances for the windows here
            mainWindow.Render();
        }
    }
}
