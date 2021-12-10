namespace Console.PddModels
{
    public partial class ListResponseModel
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("errorCode")]
        public long ErrorCode { get; set; }

        [JsonPropertyName("errorMsg")]
        public object ErrorMsg { get; set; }

        [JsonPropertyName("result")]
        public List<PddCatInfo> Result { get; set; }
    }

    public class PddCatInfo
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
