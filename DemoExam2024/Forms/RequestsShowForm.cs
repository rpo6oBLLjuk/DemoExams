namespace DemoExam2024
{
    public partial class RequestsShowForm : Form
    {
        public RequestsShowForm()
        {
            InitializeComponent();

            Bootstrap();
        }


        void Bootstrap()
        {
            DBManager.RequestsManager.LoadRequests(dataGridView1);

            bool hasGrant = DBManager.HasGrant("Requests");
            SetGrantsState(hasGrant);
        }

        private void SetGrantsState(bool allowEdit)
        {
            ApplyButton.Visible = allowEdit;


            dataGridView1.Columns[0].Visible = false;

            dataGridView1.ReadOnly = !allowEdit;
            dataGridView1.AllowUserToAddRows = allowEdit;
            dataGridView1.AllowUserToDeleteRows = allowEdit;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            DBManager.RequestsManager.SaveRequests(dataGridView1);
        }
    }
}
