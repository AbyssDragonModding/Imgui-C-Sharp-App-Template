using ImGuiApp;

public class Program
{
    public static void Main(string[] args)
    {
        // Create the renderer instance in a seperate thread
        Renderer renderer = new Renderer();
        Thread renderThread = new Thread(renderer.Start().Wait);
        renderThread.Start();
    }
}
