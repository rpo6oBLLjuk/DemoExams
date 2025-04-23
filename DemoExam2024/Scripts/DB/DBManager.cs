using MySql.Data.MySqlClient;

namespace DemoExam2024
{
    internal static class DBManager
    {
        public static RequestsManager RequestsManager { get; } = new();

        public static string Username { get; private set; } = "";
        public static string Password { get; private set; } = "";

        static string _user = "DemoExam2024_orbitgirl";
        static string _password = "f4a509767859cb09c977eefe042b2d425d9a9d1f";
        static string _server = "f1pwg.h.filess.io";
        static string _database = "DemoExam2024_orbitgirl";

        //static string ConnectionString => $"server={_host};database={_database};user={_username};password={_password};";
        static string ConnectionString = $"server={_server};user={_user};database={_database};port=3307;password={_password}";

        static bool useConnection = true;

        public static bool Login(string user, string password)
        {
            Username = user;
            Password = password;

            MessageBox.Show("Hard stop");
            return false;
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
