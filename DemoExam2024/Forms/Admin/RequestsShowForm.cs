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
            SetDataGridState();
        }

        private void SetDataGridState()
        {
            dataGridView1.Columns[0].Visible = false;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }
    }
}
