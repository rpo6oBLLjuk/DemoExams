using MySql.Data.MySqlClient;

namespace DemoExam2024
{
    internal static class DBManager
    {
        public static RequestsManager RequestsManager { get; } = new();


        static string _username = "";
        static string _password = "";
        static string _host = "localhost";
        static string _database = "DemoExam2024";

        static string ConnectionString => $"server={_host};database={_database};user={_username};password={_password};";


        public static bool Login(string user, string password)
        {
            _username = user;
            _password = password;

            return GetConnection(out _);
        }

        public static bool IsAdminUser()
        {
            if (!GetConnection(out var connection))
                return false;

            try
            {
                string query = "SELECT * FROM mysql.user WHERE User = @username AND " +
                               "(Super_priv = 'Y' OR Create_user_priv = 'Y')";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", _username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking admin privileges: " + ex.Message);
                return false;
            }
            finally
            {
                connection?.Close();
            }
        }

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check your login and password.", "Failed to connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static bool GetConnection(out MySqlConnection connection)
        {
            connection = GetConnection();
            return connection != null;
        }
    }
}
