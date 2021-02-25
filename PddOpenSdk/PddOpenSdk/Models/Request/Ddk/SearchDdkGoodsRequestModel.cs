using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class SearchDdkGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品活动标记数组，例：[4,7]，4-秒杀，7-百亿补贴，24-品牌高佣，20-行业精选，21-金牌商家，10044-潜力爆品，10475-爆品上新，其他的值请忽略
        /// </summary>
        [JsonProperty("activity_tags")]
        public List<int?> ActivityTags { get; set; }
        /// <summary>
        /// 商品类目ID，使用pdd.goods.cats.get接口获取
        /// </summary>
        [JsonProperty("cat_id")]
        public long? CatId { get; set; }
        /// <summary>
        /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为： {"uid":"11111","sid":"22222","new":1} ，其中 uid 为用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 为上下文信息标识，例如sessionId等，非必填。new字段标识是否是新用户，如果为新用户，uid请传入用户唯一标识，例如小程序的openid、app的设备号等（可自行加密）。该json字符串中也可以加入其他自定义的key。
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 已经废弃，不再支持该功能。建议使用goods_sign_list进行商品查询
        /// </summary>
        [JsonProperty("goods_id_list")]
        public List<long?> GoodsIdList { get; set; }
        /// <summary>
        /// 是否为品牌商品
        /// </summary>
        [JsonProperty("is_brand_goods")]
        public bool? IsBrandGoods { get; set; }
        /// <summary>
        /// 商品关键词，与opt_id字段选填一个或全部填写，不支持纯数字(goods_id)搜索
        /// </summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }
        /// <summary>
        /// 翻页时建议填写前页返回的list_id值
        /// </summary>
        [JsonProperty("list_id")]
        public string ListId { get; set; }
        /// <summary>
        /// 店铺类型，1-个人，2-企业，3-旗舰店，4-专卖店，5-专营店，6-普通店（未传为全部）
        /// </summary>
        [JsonProperty("merchant_type")]
        public int? MerchantType { get; set; }
        /// <summary>
        /// 店铺类型数组
        /// </summary>
        [JsonProperty("merchant_type_list")]
        public List<int?> MerchantTypeList { get; set; }
        /// <summary>
        /// 商品标签类目ID，使用pdd.goods.opt.get获取
        /// </summary>
        [JsonProperty("opt_id")]
        public long? OptId { get; set; }
        /// <summary>
        /// 默认值1，商品分页数
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }
        /// <summary>
        /// 默认100，每页商品数量
        /// </summary>
        [JsonProperty("page_size")]
        public int? PageSize { get; set; }
        /// <summary>
        /// 推广位id
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 筛选范围列表 样例：[{"range_id":0,"range_from":1,"range_to":1500},{"range_id":1,"range_from":1,"range_to":1500}]
        /// </summary>
        [JsonProperty("range_list")]
        public List<RangeListRequestModel> RangeList { get; set; }
        /// <summary>
        /// 排序方式:0-综合排序;1-按佣金比率升序;2-按佣金比例降序;3-按价格升序;4-按价格降序;5-按销量升序;6-按销量降序;7-优惠券金额排序升序;8-优惠券金额排序降序;9-券后价升序排序;10-券后价降序排序;11-按照加入多多进宝时间升序;12-按照加入多多进宝时间降序;13-按佣金金额升序排序;14-按佣金金额降序排序;15-店铺描述评分升序;16-店铺描述评分降序;17-店铺物流评分升序;18-店铺物流评分降序;19-店铺服务评分升序;20-店铺服务评分降序;27-描述评分击败同类店铺百分比升序，28-描述评分击败同类店铺百分比降序，29-物流评分击败同类店铺百分比升序，30-物流评分击败同类店铺百分比降序，31-服务评分击败同类店铺百分比升序，32-服务评分击败同类店铺百分比降序
        /// </summary>
        [JsonProperty("sort_type")]
        public int? SortType { get; set; }
        /// <summary>
        /// 是否只返回优惠券的商品，false返回所有商品，true只返回有优惠券的商品
        /// </summary>
        [JsonProperty("with_coupon")]
        public bool? WithCoupon { get; set; }
        /// <summary>
        /// 自定义屏蔽一级/二级/三级类目ID，自定义数量不超过20个;使用pdd.goods.cats.get接口获取cat_id
        /// </summary>
        [JsonProperty("block_cats")]
        public List<int?> BlockCats { get; set; }
        /// <summary>
        /// 屏蔽商品类目包：1-拼多多小程序屏蔽类目;2-虚拟类目;3-医疗器械;4-处方药;5-非处方药
        /// </summary>
        [JsonProperty("block_cat_packages")]
        public List<int?> BlockCatPackages { get; set; }
        /// <summary>
        /// goodsSign列表，支持通过goodsSign查询商品
        /// </summary>
        [JsonProperty("goods_sign_list")]
        public List<string> GoodsSignList { get; set; }
        public partial class RangeListRequestModel : PddRequestModel
        {
            /// <summary>
            /// 区间的开始值
            /// </summary>
            [JsonProperty("range_from")]
            public long? RangeFrom { get; set; }
            /// <summary>
            /// 0，最小成团价 1，券后价 2，佣金比例 3，优惠券价格 4，广告创建时间 5，销量 6，佣金金额 7，店铺描述分 8，店铺物流分 9，店铺服务分 10， 店铺描述分击败同行业百分比 11， 店铺物流分击败同行业百分比 12，店铺服务分击败同行业百分比 13，商品分 17 ，优惠券/最小团购价 18，过去两小时pv 19，过去两小时销量
            /// </summary>
            [JsonProperty("range_id")]
            public int? RangeId { get; set; }
            /// <summary>
            /// 区间的结束值
            /// </summary>
            [JsonProperty("range_to")]
            public long? RangeTo { get; set; }

        }

    }

}
