using DemoExam2024;

namespace DemoExam2024
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Form defaultForm = new MainMenuForm();
            FormManager.SetDefaultForm(defaultForm);
            Application.Run(defaultForm);
        }
    }
}