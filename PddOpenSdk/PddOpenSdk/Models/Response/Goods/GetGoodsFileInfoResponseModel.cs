using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Goods
{
    public partial class GetGoodsFileInfoResponseModel : PddResponseModel
    {
        /// <summary>
        /// goods_file_info_response
        /// </summary>
        [JsonProperty("goods_file_info_response")]
        public GoodsFileInfoResponseResponseModel GoodsFileInfoResponse { get; set; }
        public partial class GoodsFileInfoResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("list")]
            public List<ListResponseModel> List { get; set; }
            public partial class ListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 文件id
                /// </summary>
                [JsonProperty("file_id")]
                public long? FileId { get; set; }
                /// <summary>
                /// 文件状态(-2:上传失败,-1:转码失败,0:转码中,1:审核中,2:审核通过,3:审核驳回)
                /// </summary>
                [JsonProperty("status")]
                public int? Status { get; set; }
                /// <summary>
                /// 文件链接
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }

            }

        }

    }

}
