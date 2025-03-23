using MySql.Data.MySqlClient;
using System.Data;

namespace DemoExam2024
{
    internal class RequestsManager
    {
        public void AddRequest(string requestNumber, DateTime requestDate, string equipment, string faultType, string problemDescription, string clientName)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            string query = "INSERT INTO Requests (RequestNumber, RequestDate, Equipment, FaultType, ProblemDescription, ClientName) VALUES (@RequestNumber, @RequestDate, @Equipment, @FaultType, @ProblemDescription, @ClientName)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@RequestNumber", requestNumber);
                cmd.Parameters.AddWithValue("@RequestDate", requestDate);
                cmd.Parameters.AddWithValue("@Equipment", equipment);
                cmd.Parameters.AddWithValue("@FaultType", faultType);
                cmd.Parameters.AddWithValue("@ProblemDescription", problemDescription);
                cmd.Parameters.AddWithValue("@ClientName", clientName);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateRequestStatus(int requestID, string status)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            string query = "UPDATE Requests SET Status = @Status WHERE RequestID = @RequestID";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@RequestID", requestID);

                cmd.ExecuteNonQuery();
            }
        }

        public void LoadRequests(DataGridView dataGridView)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            string query = "SELECT * FROM Requests";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView.DataSource = table;
        }

        public void SaveRequests(DataGridView dataGridView)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            string query = "SELECT * FROM Requests";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
            adapter.InsertCommand = commandBuilder.GetInsertCommand();
            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            adapter.DeleteCommand = commandBuilder.GetDeleteCommand();

            DataTable table = (DataTable)dataGridView.DataSource;

            try
            {
                adapter.Update(table);
                MessageBox.Show("Изменения успешно сохранены.");
            }
            catch (MySqlException ex)
            {
                string errorMessage = ex.Message;
                if (errorMessage.Contains("doesn't have a default value"))
                {
                    string fieldName = errorMessage.Split('\'')[1];
                    MessageBox.Show($"Параметр '{fieldName}' некорректный. Укажите значение для этого поля.");
                }
                else
                {
                    MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public void LoadTableColumns(DataGridView dataGridView)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            string query = "SELECT * FROM Requests";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            table.Rows.Clear();

            dataGridView.DataSource = table;
        }

        public void SearchRequest(string requestNumber, DataGridView dataGridView)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            string query = "SELECT * FROM Requests WHERE RequestNumber = @RequestNumber";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@RequestNumber", requestNumber);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView.DataSource = table;
        }

        public void AssignRequest(int requestID, int userID)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            string query = "UPDATE Requests SET AssignedTo = @UserID WHERE RequestID = @RequestID";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@RequestID", requestID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
