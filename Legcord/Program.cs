using SharpWebview;
using SharpWebview.Content;

namespace Legcord
{
    class Program
    {
        // Set the application to Single Threaded Apartment
        // Otherwise the webview won't work on windows at least
        [STAThread]
        static void Main(string[] args)
        {
        Console.WriteLine("Legcord");
        using (var webview = new Webview())
        {
            webview
                .SetTitle("Legcord")
                .SetSize(800, 600, WebviewHint.None)
                .SetSize(400, 300, WebviewHint.Min)
                .Navigate(new UrlContent("https://discord.com/app"))
                .Run();
        }
        }
    }
}