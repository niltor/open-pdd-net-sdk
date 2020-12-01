using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class ImagesAdApiGoodsQueryGalleryResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorCode")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorMsg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("result")]
            public List<ResultResponseModel> Result { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 图片高
                /// </summary>
                [JsonProperty("imageHeight")]
                public int? ImageHeight { get; set; }
                /// <summary>
                /// 图片链接
                /// </summary>
                [JsonProperty("imageUrl")]
                public string ImageUrl { get; set; }
                /// <summary>
                /// 图片宽
                /// </summary>
                [JsonProperty("imageWidth")]
                public int? ImageWidth { get; set; }
                /// <summary>
                /// 标识轮播图排序，最小的为主轮播图
                /// </summary>
                [JsonProperty("priority")]
                public int? Priority { get; set; }

            }

        }

    }

}
