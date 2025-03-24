namespace DemoExam2024
{
    internal static class FormManager
    {
        public static Form MainForm { get; private set; }

        private static List<Form> pool = new();


        public static void SetDefaultForm(Form form)
        {
            MainForm = form;
            pool.Add(form);
        }

        public static void OpenForm<T>(bool closeCurrentForm = true) where T : Form, new()
        {
            if (closeCurrentForm && pool.Last() != MainForm)
            {
                pool.Last()?.Close();
                RemoveLastForm();
            }
            else
            {
                pool.Last()?.Hide();
            }


            if (typeof(T) != typeof(MainMenuForm))
            {
                Form CurrentForm = new T();
                pool.Add(CurrentForm);

                CurrentForm.FormClosed += ((_, _) => ShowPreviousForm());
                CurrentForm.ShowDialog();
            }
            else
            {
                MainForm?.Show();
            }
        }

        private static void ShowPreviousForm()
        {
            RemoveLastForm();
            pool.Last()?.Show();
        }

        private static void RemoveLastForm()
        {
            pool.Remove(pool.Last());
        }
    }
}
