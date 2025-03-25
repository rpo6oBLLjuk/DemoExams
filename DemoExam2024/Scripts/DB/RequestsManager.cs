using MySql.Data.MySqlClient;
using System.Data;

namespace DemoExam2024
{
    internal class RequestsManager
    {
        public void AddRequest(string equipment, string faultType, string problemDescription, string client)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            string query = "INSERT INTO `demoexam2024`.`requests` (`DateAdded`, `Equipment`, `FaultType`, `ProblemDescription`, `Client`) VALUES (@RequestDate, @Equipment, @FaultType, @ProblemDescription, @Client)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RequestDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Equipment", equipment);
                    cmd.Parameters.AddWithValue("@FaultType", faultType);
                    cmd.Parameters.AddWithValue("@ProblemDescription", problemDescription);
                    cmd.Parameters.AddWithValue("@Client", client);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Request applied", "Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Apply Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateRequestStatus(int requestNumber, string status, string worker)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            string query = "UPDATE Requests SET Status = @Status, Executor = @Worker WHERE RequestID = @RequestID";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Worker", worker);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@RequestID", requestNumber);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Request status updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Status update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void LoadStatusesToComboBox(ComboBox statusComboBox)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            try
            {
                string query = @"
                    SELECT COLUMN_TYPE 
                    FROM INFORMATION_SCHEMA.COLUMNS 
                    WHERE TABLE_SCHEMA = DATABASE() 
                      AND TABLE_NAME = 'Requests' 
                      AND COLUMN_NAME = 'status'";

                using (var command = new MySqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar()?.ToString();

                    if (result != null && result.StartsWith("enum("))
                    {
                        string enumValues = result
                            .Substring(5, result.Length - 6)
                            .Replace("'", "");

                        statusComboBox.DataSource = enumValues.Split(',')
                            .Select(s => s.Trim())
                            .ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке статусов: {ex.Message}");
            }
            finally
            {
                connection?.Close();
            }
        }

        public void SearchRequest(int requestNumber, DataGridView dataGridView)
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

        public void RemoveRequest(int requestNumber)
        {
            if (!DBManager.GetConnection(out MySqlConnection connection))
                return;

            string query = "DELETE FROM `demoexam2024`.`requests` WHERE `RequestId` = @RequestId";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@RequestId", requestNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Request deleted successfully", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Request not found", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting request: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
