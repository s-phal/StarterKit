namespace StarterKit.Application.Config
{
    public class LoadDbConfig
    {
        public static void LoadEnvFile()
        {
            var envFile = Path.Combine(Environment.CurrentDirectory, "Application", "Config", ".env");

            if (!File.Exists(envFile))
                return;

            foreach (var line in File.ReadAllLines(envFile))
            {
                var keyValues = line.Split(
                    '=',
                    StringSplitOptions.RemoveEmptyEntries);

                if (keyValues.Length != 2)
                    continue;

                Environment.SetEnvironmentVariable(keyValues[0], keyValues[1]);
            }
        }
    }
}
