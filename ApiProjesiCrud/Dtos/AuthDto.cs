namespace ApiProjesiCrud.Dtos
{
    public class AuthDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string GrantType { get; set; }
    }
    public static class GrantTypes
    {
        public const string Password = "password";
        public const string ClientCredentials = "client_credentials";
    }
}
