using ImGuiApp;
using System;
using System.Threading;

public class Program
{
    // Code is modified from the original in the video: https://youtu.be/5yVpcJo_jjs?si=R4CsNZ4RTE-dQmhk
    // with the goal of minimizing cpu usage when not needed

    // ManualResetEvent is used to signal between threads when rendering is complete
    private static ManualResetEvent renderComplete = new ManualResetEvent(false);

    public static void Main(string[] args)
    {
        // Create an instance of the Renderer class
        Renderer renderer = new Renderer();

        // Start a new thread for rendering
        Thread renderThread = new Thread(() =>
        {
            // Call the Start method on the renderer instance to begin rendering
            renderer.Start();
            // Signal that rendering is complete by setting the ManualResetEvent
            renderComplete.Set();
        });

        // Start the rendering thread
        renderThread.Start();

        // Main thread waits for the rendering thread to signal completion
        while (true)
        {
            // Wait for the renderComplete signal for up to 1 second
            if (renderComplete.WaitOne(1000)) // Wait for 1 second or until signaled
            {
                // Exit the loop since rendering is complete
                break;
            }
        }
    }
}
