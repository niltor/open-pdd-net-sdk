namespace PddOpenSdk.Models.Response.Ad;
public partial class ImagesAdApiGoodsQueryGalleryResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("response")]
    public ResponseResponse Response { get; set; }
    public partial class ResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("errorMsg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("result")]
        public List<ResultResponse> Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        public partial class ResultResponse : PddResponseModel
        {

            /// <summary>
            /// 图片高
            /// </summary>
            [JsonPropertyName("imageHeight")]
            public int? ImageHeight { get; set; }

            /// <summary>
            /// 图片链接
            /// </summary>
            [JsonPropertyName("imageUrl")]
            public string ImageUrl { get; set; }

            /// <summary>
            /// 图片宽
            /// </summary>
            [JsonPropertyName("imageWidth")]
            public int? ImageWidth { get; set; }

            /// <summary>
            /// 标识轮播图排序，最小的为主轮播图
            /// </summary>
            [JsonPropertyName("priority")]
            public int? Priority { get; set; }

        }

    }

}

