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
            if (DBManager.Login(loginTextBox.Text, passwordTextBox.Text))
                RequestsShowFormOpen();
        }

        private void RequestsShowFormOpen() => FormManager.OpenForm<RequestsShowForm>();
    }
}
