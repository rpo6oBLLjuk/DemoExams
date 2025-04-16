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

            if (dataGridView1 == null)
            {
                MessageBox.Show("Requests not loaded");
                return;
            }
            SetDataGridState();
        }

        private void SetDataGridState()
        {
            if (dataGridView1.Columns != null && dataGridView1.ColumnCount > 0)
                dataGridView1.Columns[0].Visible = false;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }
    }
}
