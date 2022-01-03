namespace Blog
{
    public static class Configuration
    {
        public static string JwtKey = "evZbbuXl80iODM3iZnw8bw";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_G2P9C7nH1UWdtE19Kgz69Q==";
        public static SMTPConfiguration SMTP = new();

        public class SMTPConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}
