namespace PddOpenSdk.Models.Response.Goods;
public partial class GetGoodsFileInfoResponse : PddResponseModel
{

    /// <summary>
    /// goods_file_info_response
    /// </summary>
    [JsonPropertyName("goods_file_info_response")]
    public GoodsFileInfoResponseResponse GoodsFileInfoResponse { get; set; }
    public partial class GoodsFileInfoResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("list")]
        public List<ListResponse> List { get; set; }
        public partial class ListResponse : PddResponseModel
        {

            /// <summary>
            /// 文件id
            /// </summary>
            [JsonPropertyName("file_id")]
            public long? FileId { get; set; }

            /// <summary>
            /// 文件状态(-2:上传失败,-1:转码失败,0:转码中,1:审核中,2:审核通过,3:审核驳回)
            /// </summary>
            [JsonPropertyName("status")]
            public int? Status { get; set; }

            /// <summary>
            /// 文件链接
            /// </summary>
            [JsonPropertyName("url")]
            public string Url { get; set; }

        }

    }

}

