namespace StarterKit.Application.Config
{
    public class DBConnection
    {
        public static string GetConnectionString()
        {
            bool isDev = true;

            var hostName = Environment.GetEnvironmentVariable("DB_HOST");
            var portNumber = Environment.GetEnvironmentVariable("DB_PORT");
            var dbName = Environment.GetEnvironmentVariable("DB_DATABASE");
            var userName = Environment.GetEnvironmentVariable("DB_USERNAME");
            var passWord = Environment.GetEnvironmentVariable("DB_PASSWORD");

            if (isDev)
            {
                dbName = "codecloner_dev";
            }

            return $"Server={hostName};Port={portNumber};Database={dbName};User Id={userName};Password={passWord};";
        }
    }
}
