namespace FantasyGoldenLeague
{
    public class AppSettings
    {
        public ServiceSettings FantasyGoldenLeagueApi { get; set; }
        public string ClientSecret { get; set; }
    }
    public class ServiceSettings : UserCredentials
    {
        public string Url { get; set; }
    }
    public class UserCredentials
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
