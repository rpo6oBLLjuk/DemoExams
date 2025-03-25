namespace DemoExam2024.Forms.Admin
{
    public partial class RemoveRequest : Form
    {
        public RemoveRequest()
        {
            InitializeComponent();
        }

        private void RemoveRequestButton_Click(object sender, EventArgs e)
        {
            DBManager.RequestsManager.RemoveRequest(int.Parse(RemoveRequestText.Text.Replace(" ", "")));
        }
    }
}
