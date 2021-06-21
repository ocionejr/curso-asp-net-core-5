namespace RestWithASPNETUdemy.Configurations
{
    public class TokenConfiguration
    {
        public string audience { get; set; }
        public string issuer { get; set; }
        public string secret { get; set; }
        public int minutes { get; set; }
        public int daysToExpiry { get; set; }
    }
}
