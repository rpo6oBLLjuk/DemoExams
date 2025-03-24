using DemoExam2024.Forms.Admin;

namespace DemoExam2024.Forms
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AddRequestButton_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<AddRequest>(false);
        }

        private void ShowRequestsButton_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<RequestsShowForm>(false);
        }

        private void RemoveRequestButton_Click(object sender, EventArgs e)
        {

        }
    }
}
