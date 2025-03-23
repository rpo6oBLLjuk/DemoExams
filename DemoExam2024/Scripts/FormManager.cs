namespace DemoExam2024
{
    internal static class FormManager
    {
        public static Form CurrentForm { get; private set; }
        public static Form MainForm { get; private set; }


        public static void SetDefaultForm(Form form) => MainForm = form;

        public static void OpenForm<T>(bool closeCurrentForm = true) where T : Form, new()
        {
            if (closeCurrentForm)
            {
                if (CurrentForm != null && CurrentForm != MainForm)
                {
                    CurrentForm.Close();
                }
            }

            if (typeof(T) != typeof(MainMenuForm))
            {
                CurrentForm = new T();
                CurrentForm.ShowDialog();
            }
            else
            {
                CurrentForm = MainForm;
                MainForm?.Show();
            }
        }
    }
}
