namespace Acelist
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();

            boundary.LoginUI loginui = new boundary.LoginUI("login");
            Application.Run(loginui);

            if (loginui.loginGranteed == true)
            {
                Application.Run(new boundary.MainMenuUI(loginui.idxUsernameUsed));
            }

        }
    }
}