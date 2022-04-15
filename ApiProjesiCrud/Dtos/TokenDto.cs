namespace ApiProjesiCrud.Dtos
{
    public static class TokenExpireDateHelper
    {
        /// <summary>
        /// 3600 saniye değerini döndürür
        /// </summary>
        public static int GetExpireDateMinutes = 3600;
    }

    public class TokenDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int ExpireDateSeconds { get; set; } = TokenExpireDateHelper.GetExpireDateMinutes; // expire date minutes kaç saniye sonra sonra expire olacağı bilgisi
        public string TokenType { get; set; } = "Bearer";

    }
}
