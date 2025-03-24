namespace DemoExam2024.Forms.Admin
{
    public partial class AddRequest : Form
    {
        public AddRequest()
        {
            InitializeComponent();
        }

        private void ApplyRequestButton_Click(object sender, EventArgs e)
        {
            DBManager.RequestsManager.AddRequest(EquipmentText.Text, FaultTypeText.Text, ProblemDescriptionText.Text, ClientText.Text);
        }
    }
}
