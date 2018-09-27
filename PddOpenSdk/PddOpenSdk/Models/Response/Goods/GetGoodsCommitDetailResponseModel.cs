using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Goods
{
    public class Spec
    {

        /// <summary>
        /// Examples: 1216
        /// </summary>
        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        /// <summary>
        /// Examples: "尺寸"
        /// </summary>
        [JsonProperty("parent_name")]
        public string ParentName { get; set; }

        /// <summary>
        /// Examples: 25, 2
        /// </summary>
        [JsonProperty("spec_id")]
        public int SpecId { get; set; }

        /// <summary>
        /// Examples: "L", "XL"
        /// </summary>
        [JsonProperty("spec_name")]
        public string SpecName { get; set; }
    }

    public class CommitSkuList
    {

        /// <summary>
        /// Examples: 27899733839, 27899733840
        /// </summary>
        [JsonProperty("sku_id")]
        public object SkuId { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("is_onsale")]
        public int IsOnsale { get; set; }

        /// <summary>
        /// Examples: 999
        /// </summary>
        [JsonProperty("limit_quantity")]
        public int LimitQuantity { get; set; }

        /// <summary>
        /// Examples: 1900
        /// </summary>
        [JsonProperty("multi_price")]
        public int MultiPrice { get; set; }

        /// <summary>
        /// Examples: 2200
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Examples: 1000
        /// </summary>
        [JsonProperty("weight")]
        public int Weight { get; set; }

        /// <summary>
        /// Examples: "http://t06img.yangkeduo.com/images/2018-04-15/ced035033b5d40b589140af882621c03.jpg"
        /// </summary>
        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Examples: [{"parent_id":1216,"parent_name":"尺寸","spec_id":25,"spec_name":"L"}], [{"parent_id":1216,"parent_name":"尺寸","spec_id":2,"spec_name":"XL"}]
        /// </summary>
        [JsonProperty("spec")]
        public IList<Spec> Spec { get; set; }

        /// <summary>
        /// Examples: "L", "XL"
        /// </summary>
        [JsonProperty("out_sku_sn")]
        public string OutSkuSn { get; set; }
    }

    public class GoodsCommitDetailResponse
    {

        /// <summary>
        /// Examples: 3576756018
        /// </summary>
        [JsonProperty("goods_commit_id")]
        public long GoodsCommitId { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("goods_status")]
        public int GoodsStatus { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("commit_message")]
        public object CommitMessage { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("deleted")]
        public int Deleted { get; set; }

        /// <summary>
        /// Examples: 1620657673
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: 999999
        /// </summary>
        [JsonProperty("buy_limit")]
        public int BuyLimit { get; set; }

        /// <summary>
        /// Examples: ["http://t06img.yangkeduo.com/images/2018-06-06/2a3d1cbd3ae3acf52b16858a38a17602.jpeg"]
        /// </summary>
        [JsonProperty("carousel_gallery_list")]
        public IList<string> CarouselGalleryList { get; set; }

        /// <summary>
        /// Examples: 1398
        /// </summary>
        [JsonProperty("cat_id")]
        public int CatId { get; set; }

        /// <summary>
        /// Examples: 5671892
        /// </summary>
        [JsonProperty("cost_template_id")]
        public int CostTemplateId { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("customer_num")]
        public int CustomerNum { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("goods_type")]
        public int GoodsType { get; set; }

        /// <summary>
        /// Examples: "第一个"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: "测试"
        /// </summary>
        [JsonProperty("goods_desc")]
        public string GoodsDesc { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("tiny_name")]
        public string TinyName { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("warehouse")]
        public string Warehouse { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("is_customs")]
        public int IsCustoms { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("customs")]
        public string Customs { get; set; }

        /// <summary>
        /// Examples: 10000
        /// </summary>
        [JsonProperty("market_price")]
        public int MarketPrice { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("is_pre_sale")]
        public int IsPreSale { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("pre_sale_time")]
        public int PreSaleTime { get; set; }

        /// <summary>
        /// Examples: 172800
        /// </summary>
        [JsonProperty("shipment_limit_second")]
        public int ShipmentLimitSecond { get; set; }

        /// <summary>
        /// Examples: 999999
        /// </summary>
        [JsonProperty("order_limit")]
        public int OrderLimit { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("is_refundable")]
        public int IsRefundable { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("is_folt")]
        public int IsFolt { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("fabric_id")]
        public object FabricId { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("fabric_content_id")]
        public object FabricContentId { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("warm_tips")]
        public string WarmTips { get; set; }

        /// <summary>
        /// Examples: [{"sku_id":27899733839,"is_onsale":1,"limit_quantity":999,"multi_price":1900,"price":2200,"quantity":0,"weight":1000,"thumb_url":"http://t06img.yangkeduo.com/images/2018-04-15/ced035033b5d40b589140af882621c03.jpg","spec":[{"parent_id":1216,"parent_name":"尺寸","spec_id":25,"spec_name":"L"}],"out_sku_sn":"L"},{"sku_id":27899733840,"is_onsale":1,"limit_quantity":999,"multi_price":1900,"price":2200,"quantity":0,"weight":1000,"thumb_url":"http://t06img.yangkeduo.com/images/2018-04-15/ced035033b5d40b589140af882621c03.jpg","spec":[{"parent_id":1216,"parent_name":"尺寸","spec_id":2,"spec_name":"XL"}],"out_sku_sn":"XL"}]
        /// </summary>
        [JsonProperty("sku_list")]
        public IList<CommitSkuList> SkuList { get; set; }

        /// <summary>
        /// Examples: "http://t17img.yangkeduo.com/images/2018-06-06/826765dee04448ede2ae17349c64dba3.jpeg"
        /// </summary>
        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Examples: "http://t06img.yangkeduo.com/images/2018-06-06/05020ca3a6613b49ee87c9865a8d906c.jpeg"
        /// </summary>
        [JsonProperty("hd_thumb_url")]
        public string HdThumbUrl { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Examples: ["http://t06img.yangkeduo.com/images/2018-06-06/2a3d1cbd3ae3acf52b16858a38a17602.jpeg"]
        /// </summary>
        [JsonProperty("detail_gallery_list")]
        public IList<string> DetailGalleryList { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("outer_goods_id")]
        public string OuterGoodsId { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("shelf_life")]
        public object ShelfLife { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("start_production_date")]
        public object StartProductionDate { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("end_production_date")]
        public object EndProductionDate { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("production_license")]
        public object ProductionLicense { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("production_standard_number")]
        public object ProductionStandardNumber { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("second_hand")]
        public int SecondHand { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("paper_net_weight")]
        public object PaperNetWeight { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("paper_length")]
        public object PaperLength { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("paper_width")]
        public object PaperWidth { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("paper_plies_num")]
        public object PaperPliesNum { get; set; }
    }

    public class GetGoodsCommitDetailResponseModel
    {

        /// <summary>
        /// Examples: {"goods_commit_id":3576756018,"goods_status":2,"commit_message":null,"deleted":0,"goods_id":1620657673,"buy_limit":999999,"carousel_gallery_list":["http://t06img.yangkeduo.com/images/2018-06-06/2a3d1cbd3ae3acf52b16858a38a17602.jpeg"],"cat_id":1398,"cost_template_id":5671892,"country_id":0,"customer_num":2,"goods_type":1,"goods_name":"第一个","goods_desc":"测试","tiny_name":"","warehouse":"","is_customs":0,"customs":"","market_price":10000,"is_pre_sale":0,"pre_sale_time":0,"shipment_limit_second":172800,"order_limit":999999,"is_refundable":1,"is_folt":1,"fabric_id":null,"fabric_content_id":null,"warm_tips":"","sku_list":[{"sku_id":27899733839,"is_onsale":1,"limit_quantity":999,"multi_price":1900,"price":2200,"quantity":0,"weight":1000,"thumb_url":"http://t06img.yangkeduo.com/images/2018-04-15/ced035033b5d40b589140af882621c03.jpg","spec":[{"parent_id":1216,"parent_name":"尺寸","spec_id":25,"spec_name":"L"}],"out_sku_sn":"L"},{"sku_id":27899733840,"is_onsale":1,"limit_quantity":999,"multi_price":1900,"price":2200,"quantity":0,"weight":1000,"thumb_url":"http://t06img.yangkeduo.com/images/2018-04-15/ced035033b5d40b589140af882621c03.jpg","spec":[{"parent_id":1216,"parent_name":"尺寸","spec_id":2,"spec_name":"XL"}],"out_sku_sn":"XL"}],"thumb_url":"http://t17img.yangkeduo.com/images/2018-06-06/826765dee04448ede2ae17349c64dba3.jpeg","hd_thumb_url":"http://t06img.yangkeduo.com/images/2018-06-06/05020ca3a6613b49ee87c9865a8d906c.jpeg","image_url":"","detail_gallery_list":["http://t06img.yangkeduo.com/images/2018-06-06/2a3d1cbd3ae3acf52b16858a38a17602.jpeg"],"outer_goods_id":"","shelf_life":null,"start_production_date":null,"end_production_date":null,"production_license":null,"production_standard_number":null,"second_hand":0,"paper_net_weight":null,"paper_length":null,"paper_width":null,"paper_plies_num":null}
        /// </summary>
        [JsonProperty("goods_commit_detail_response")]
        public GoodsCommitDetailResponse GoodsCommitDetailResponse { get; set; }
    }


}
