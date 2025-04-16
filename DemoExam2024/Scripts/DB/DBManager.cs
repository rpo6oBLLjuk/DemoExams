using MySql.Data.MySqlClient;

namespace DemoExam2024
{
    internal static class DBManager
    {
        public static RequestsManager RequestsManager { get; } = new();

        public static string Username { get; private set; } = "";
        public static string Password { get; private set; } = "";
        static string _host = "localhost";
        static string _database = "DemoExam2024";

        static string ConnectionString => $"server={_host};database={_database};user={Username};password={Password};ConnectionTimeout=1;";

        static bool useConnection = false;

        public static bool Login(string user, string password)
        {
            Username = user;
            Password = password;

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
                    cmd.Parameters.AddWithValue("@username", Username);
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
            if (!useConnection)
                return null;

            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (MySqlException mySqlEx)
            {
                string errorMessage = mySqlEx.Number switch
                {
                    1042 => "Сервер MySQL недоступен",
                    1045 => "Неверный логин или пароль",
                    _ => mySqlEx.Message
                };
                MessageBox.Show(errorMessage, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
