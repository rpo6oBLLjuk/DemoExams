namespace DemoExam2024.Forms.Worker
{
    public partial class ChangeRequestStatus : Form
    {
        public ChangeRequestStatus()
        {
            InitializeComponent();


            DBManager.RequestsManager.LoadStatusesToComboBox(StatusComboBox);
            //StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //StatusComboBox.DataSource = new List<string> { "в ожидании", "в работе", "выполнено" };
        }

        private void ApplyStatusButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(RequestNumberText.Text.Replace(" ", ""), out int result))
                DBManager.RequestsManager.UpdateRequestStatus(result, StatusComboBox.Text, DBManager.Username);
            else
                MessageBox.Show("Incorrect Request number");
        }
    }
}
