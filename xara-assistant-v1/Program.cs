using xara_assistant_v1.Forms;
using xara_assistant_v1.Services.Core;

namespace xara_assistant_v1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Home( new Core() ));
        }
    }
}