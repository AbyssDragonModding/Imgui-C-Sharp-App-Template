// Example Main Window class using the ImguiWindow as a base class
using System;
using System.Numerics;
using ImGuiApp;
using ImGuiNET;

namespace ImGuiApp
{
    internal class MainWindow : ImguiWindow
    {
        static Vector4 winColor;

        static ImGuiStylePtr style;
        public MainWindow() : base("Example Menu", new Vector2(300, 600), true, ImGuiWindowFlags.NoCollapse) 
        {
            style = ImGui.GetStyle();
            winColor = new Vector4(1, 1, 1, 1);
        }
        protected override void Widgets()
        {
            try
            {
                ImGui.SetWindowFontScale(1.6f);
                ImGui.TextColored(winColor, "Colored Text");
                ImGui.ColorPicker4("##windowColor", ref winColor, ImGuiColorEditFlags.DisplayRGB);
                if (ImGui.Button("Apply Styles"))
                {
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
