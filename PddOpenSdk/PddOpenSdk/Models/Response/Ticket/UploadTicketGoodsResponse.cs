namespace PddOpenSdk.Models.Response.Ticket;
public partial class UploadTicketGoodsResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("goods_upload_response")]
    public GoodsUploadResponseResponse GoodsUploadResponse { get; set; }
    public partial class GoodsUploadResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 草稿id
        /// </summary>
        [JsonPropertyName("goods_commit_id")]
        public long? GoodsCommitId { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("goods_id")]
        public long? GoodsId { get; set; }

    }

}

