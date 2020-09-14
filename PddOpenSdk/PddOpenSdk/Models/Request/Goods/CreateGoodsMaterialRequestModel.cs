using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class CreateGoodsMaterialRequestModel : PddRequestModel
    {
        /// <summary>
        /// 素材内容（一般为图片链接）
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
        /// <summary>
        /// 图片空间文件id
        /// </summary>
        [JsonProperty("file_id")]
        public long FileId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id")]
        public long GoodsId { get; set; }
        /// <summary>
        /// 素材类型（1：白底图；3：长图）
        /// </summary>
        [JsonProperty("material_type")]
        public int MaterialType { get; set; }

    }

}
