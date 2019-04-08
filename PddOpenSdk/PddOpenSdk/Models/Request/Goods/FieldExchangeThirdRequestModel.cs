using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Goods
{
    public partial class FieldExchangeThirdRequestModel : PddRequestModel
    {
        /// <summary>
        /// 第三方平台商品的商品ID
        /// </summary>
        [JsonProperty("num_iid")]
        public string NumIid { get; set; }
        /// <summary>
        /// 第三方平台商品的商品标题，例如“马克杯”
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// 第三方平台商品所属的叶子类目id，例如“162653”
        /// </summary>
        [JsonProperty("cid")]
        public string Cid { get; set; }
        /// <summary>
        /// 第三方平台商品描述，例如“马克杯，高16.cm，白色，http://testimg.yangkeduo.com/pdd_oms/2018-07-13/06b79325f5235b9d420201414ca57488.jpeg"
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }
        /// <summary>
        /// 第三方平台商品主图片地址，例如“http://testimg.yangkeduo.com/pdd_oms/2018-07-13/06b79325f5235b9d420201414ca57488.jpeg"
        /// </summary>
        [JsonProperty("pic_url")]
        public string PicUrl { get; set; }
        /// <summary>
        /// 第三方平台商品新旧程度，全新new，闲置unused，二手second
        /// </summary>
        [JsonProperty("stuff_status")]
        public string StuffStatus { get; set; }
        /// <summary>
        /// 第三方平台商品的商家外部编码，可与商家外部系统对应，例如“34143554352“
        /// </summary>
        [JsonProperty("outer_id")]
        public string OuterId { get; set; }
        /// <summary>
        /// 拼多多的物流运费模板ID，可使用pdd.logistics.template.get获取
        /// </summary>
        [JsonProperty("cost_template_id")]
        public long CostTemplateId { get; set; }
        /// <summary>
        /// 第三方平台商品轮播图地址（包括主图)，最多传5张，例如：; “http://testimg.yangkeduo.com/pdd_oms/2018-07-13/06b79325f5235b9d420201414ca57488.jpeg”
        /// </summary>
        [JsonProperty("item_imgs_url")]
        public string ItemImgsUrl { get; set; }
        /// <summary>
        /// 第三方; ; 平台商品的sku内容，包括：sku的销售属性组合字符串properties_name（必填，当您上传的商品是单品时可以不传），sku对应的商品数量quantity（必填），sku应的商品价格price（必填），sku的商家外部outer_id（选填），例如：[{"outer_id":"1","price":51, "properties_name":"1627207:28332:颜色:浅灰色","quantity":11}]
        /// </summary>
        [JsonProperty("skus")]
        public string Skus { get; set; }
        /// <summary>
        /// 拼多多商品分类id，传入的第三方cid无法对应的情况下，可以选择传此id
        /// </summary>
        [JsonProperty("pdd_cid")]
        public string PddCid { get; set; }

    }

}
