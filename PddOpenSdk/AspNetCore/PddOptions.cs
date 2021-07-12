namespace PddOpenSdk.AspNetCore
{
    public class PddOptions
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string CallbackUrl { get; set; }
        public string AccessToken { get; set; }
        /// <summary>
        /// socket ĞÄÌø¼ä¸ô
        /// </summary>
        public int HeartBeatSeconds { get; set; } = 5;
    }
}