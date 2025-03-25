using DemoExam2024.Forms.Worker;

namespace DemoExam2024.Forms
{
    public partial class WorkerPanel : Form
    {
        public WorkerPanel()
        {
            InitializeComponent();
        }

        private void ChangeStatusButton_Click(object sender, EventArgs e)
        {
            FormManager.OpenForm<ChangeRequestStatus>(false);
        }
    }
}
