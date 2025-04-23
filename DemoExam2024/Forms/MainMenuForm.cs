using DemoExam2024.Forms;

namespace DemoExam2024
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (!DBManager.Login(loginTextBox.Text, passwordTextBox.Text))
                return;

            if (DBManager.IsAdminUser())
                FormManager.OpenForm<AdminPanel>();
            else
                FormManager.OpenForm<WorkerPanel>();
        }
    }
}
