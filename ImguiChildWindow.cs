using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Imgui_CSharp_App_Template_1_1_11
{
    public class ImguiChildWindow
    {
        // Class Variables
        string _windowID;
        public string WindowID
        {
            get { return _windowID; }
            set { _windowID = value; }
        }
        // Constructor
        public ImguiChildWindow(string windowID)
        {
            WindowID = windowID;
        }
        public virtual void Render()
        {
            try
            {
                ImGui.BeginChild($"##{WindowID}");
                Widgets();
                ImGui.EndChild();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }

        // Class methods
        protected virtual void Widgets()
        {
            ImGui.Text("Example Widget");
        }
    }
}
