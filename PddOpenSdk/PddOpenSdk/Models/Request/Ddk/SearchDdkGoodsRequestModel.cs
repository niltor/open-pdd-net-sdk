using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class SearchDdkGoodsRequestModel : PddRequestModel {
        /// <summary>
        /// 商品关键词，与opt_id字段选填一个或全部填写
        /// </summary>
        [JsonProperty ("keyword")]
        public string Keyword { get; set; }
        /// <summary>
        /// 商品标签类目ID，使用pdd.goods.opt.get获取
        /// </summary>
        [JsonProperty ("opt_id")]
        public long? OptId { get; set; }
        /// <summary>
        /// 默认值1，商品分页数
        /// </summary>
        [JsonProperty ("page")]
        public int Page { get; set; }
        /// <summary>
        /// 默认100，每页商品数量
        /// </summary>
        [JsonProperty ("page_size")]
        public int PageSize { get; set; }
        /// <summary>
        /// 排序方式:0-综合排序;1-按佣金比率升序;2-按佣金比例降序;3-按价格升序;4-按价格降序;5-按销量升序;6-按销量降序;7-优惠券金额排序升序;8-优惠券金额排序降序;9-券后价升序排序;10-券后价降序排序;11-按照加入多多进宝时间升序;12-按照加入多多进宝时间降序;13-按佣金金额升序排序;14-按佣金金额降序排序;15-店铺描述评分升序;16-店铺描述评分降序;17-店铺物流评分升序;18-店铺物流评分降序;19-店铺服务评分升序;20-店铺服务评分降序;27-描述评分击败同类店铺百分比升序，28-描述评分击败同类店铺百分比降序，29-物流评分击败同类店铺百分比升序，30-物流评分击败同类店铺百分比降序，31-服务评分击败同类店铺百分比升序，32-服务评分击败同类店铺百分比降序
        /// </summary>
        [JsonProperty ("sort_type")]
        public int SortType { get; set; }
        /// <summary>
        /// 是否只返回优惠券的商品，false返回所有商品，true只返回有优惠券的商品
        /// </summary>
        [JsonProperty ("with_coupon")]
        public bool? WithCoupon { get; set; }
        /// <summary>
        /// 范围列表，可选值：[{"range_id":0,"range_from":1,"range_to":1500},{"range_id":1,"range_from":1,"range_to":1500}]
        /// </summary>
        [JsonProperty ("range_list")]
        public string RangeList { get; set; }
        /// <summary>
        /// 商品类目ID，使用pdd.goods.cats.get接口获取
        /// </summary>
        [JsonProperty ("cat_id")]
        public long? CatId { get; set; }
        /// <summary>
        /// 商品ID列表。例如：[123456,123]，当入参带有goods_id_list字段，将不会以opt_id、 cat_id、keyword维度筛选商品
        /// </summary>
        [JsonProperty ("goods_id_list")]
        public List<long?> GoodsIdList { get; set; }
        /// <summary>
        /// 招商多多客ID
        /// </summary>
        [JsonProperty ("zs_duo_id")]
        public long? ZsDuoId { get; set; }
        /// <summary>
        /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店（未传为全部）
        /// </summary>
        [JsonProperty ("merchant_type")]
        public int MerchantType { get; set; }
        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty ("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty ("custom_parameters")]
        public string CustomParameters { get; set; }

    }

}