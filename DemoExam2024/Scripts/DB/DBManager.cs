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

        public static bool HasGrant(string tableName)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string query = $"SHOW GRANTS FOR '{_username}'@'{_host}';";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        bool hasEditRights = false;

                        while (reader.Read())
                        {
                            string grant = reader.GetString(0);

                            if ((grant.Contains($"`{tableName}`") || grant.Contains("*.*")) && (grant.Contains("INSERT") || grant.Contains("UPDATE") || grant.Contains("DELETE") || grant.Contains("ALL PRIVILEGES")))
                            {
                                hasEditRights = true;
                                break;
                            }
                        }

                        if (hasEditRights)
                        {
                            Console.WriteLine($"Пользователь '{_username}' имеет права на редактирование таблицы '{tableName}'.");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine($"Пользователь '{_username}' НЕ имеет прав на редактирование таблицы '{tableName}'.");
                            return false;
                        }
                    }
                }
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
