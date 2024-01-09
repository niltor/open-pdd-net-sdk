namespace PddOpenSdk.Models.Request.Ddk;
public partial class GenerateDdkRpPromUrl
{

    /// <summary>
    /// 初始金额（单位分），有效金额枚举值：300、500、700、1100和1600，默认300
    /// </summary>
    [JsonPropertyName("amount")]
    public long? Amount { get; set; }

    /// <summary>
    /// 营销工具类型，必填：-1-活动列表，0-红包(需申请推广权限)，2–新人红包，3-刮刮卡，5-员工内购，10-生成绑定备案链接，12-砸金蛋，14-千万补贴B端页面，15-充值中心B端页面，16-千万补贴C端页面，17-千万补贴投票页面，23-超级红包，24-礼金全场N折活动B端页面，27-带货赢千万，28-满减券活动B端页面，29-满减券活动C端页面，30-免单B端页面，31-免单C端页面，32-转盘得现金B端页面，33-转盘得现金C端页面，34-千万神券C端页面，35-千万神券B端页面，36-爆品日历B端页面，37-超级红包B端推品页，39-母婴馆C端页面，40-母婴馆B端页面，41-限时折扣B端页面，42-超级红包9.9C端活动页
    /// </summary>
    [JsonPropertyName("channel_type")]
    public int? ChannelType { get; set; }

    /// <summary>
    /// 自定义参数，为链接打上自定义标签；自定义参数最长限制64个字节；格式为：  {"uid":"11111","sid":"22222"} ，其中 uid 用户唯一标识，可自行加密后传入，每个用户仅且对应一个标识，必填； sid 上下文信息标识，例如sessionId等，非必填。该json字符串中也可以加入其他自定义的key。（如果使用GET请求，请使用URLEncode处理参数）
    /// </summary>
    [JsonPropertyName("custom_parameters")]
    public string CustomParameters { get; set; }

    /// <summary>
    /// 一元购自定义参数，json格式，例如:{"goods_sign":"Y9b2_0uSWMFPGSaVwvfZAlm_y2ADLWZl_JQ7UYaS80K"}
    /// </summary>
    [JsonPropertyName("diy_one_yuan_param")]
    public DiyOneYuanParamModel DiyOneYuanParam { get; set; }

    /// <summary>
    /// 红包自定义参数，json格式
    /// </summary>
    [JsonPropertyName("diy_red_packet_param")]
    public DiyRedPacketParamModel DiyRedPacketParam { get; set; }

    /// <summary>
    /// 超级红包自定义参数，json格式
    /// </summary>
    [JsonPropertyName("diy_sp_red_packet_param")]
    public DiySpRedPacketParamModel DiySpRedPacketParam { get; set; }

    /// <summary>
    /// 扩展参数
    /// </summary>
    [JsonPropertyName("ext_params")]
    public Dictionary<string, object> ExtParams { get; set; }

    /// <summary>
    /// 是否生成qq小程序
    /// </summary>
    [JsonPropertyName("generate_qq_app")]
    public bool? GenerateQqApp { get; set; }

    /// <summary>
    /// 是否返回 schema URL
    /// </summary>
    [JsonPropertyName("generate_schema_url")]
    public bool? GenerateSchemaUrl { get; set; }

    /// <summary>
    /// 是否生成微信shortLink，该字段支持超红c端活动页、超红二合一、b端推品页，单个渠道每天生成的shortLink数量有限，请合理生成shortLink链接
    /// </summary>
    [JsonPropertyName("generate_short_link")]
    public bool? GenerateShortLink { get; set; }

    /// <summary>
    /// 是否生成短链接。true-是，false-否，默认false
    /// </summary>
    [JsonPropertyName("generate_short_url")]
    public bool? GenerateShortUrl { get; set; }

    /// <summary>
    /// 是否生成拼多多福利券微信小程序推广信息
    /// </summary>
    [JsonPropertyName("generate_we_app")]
    public bool? GenerateWeApp { get; set; }

    /// <summary>
    /// 推广位列表，长度最大为1，例如：["60005_612"]。活动页生链要求传入授权备案信息，不支持批量生链。
    /// </summary>
    [JsonPropertyName("p_id_list")]
    public List<string> PIdList { get; set; }

    /// <summary>
    /// 刮刮卡指定金额（单位分），可指定2-100元间数值，即有效区间为：[200,10000]
    /// </summary>
    [JsonPropertyName("scratch_card_amount")]
    public long? ScratchCardAmount { get; set; }

    /// <summary>
    /// 千万神券C端生链扩展参数 支持置顶活动ID 和 置顶商品(品牌活动才支持)
    /// </summary>
    [JsonPropertyName("tmcc_param")]
    public TmccParamModel TmccParam { get; set; }

    /// <summary>
    /// 招商DuoID
    /// </summary>
    [JsonPropertyName("zs_duo_id")]
    public long? ZsDuoId { get; set; }
    public partial class DiyOneYuanParamModel
    {

        /// <summary>
        /// 商品goodsSign，支持通过goodsSign查询商品。goodsSign是加密后的goodsId, goodsId已下线，请使用goodsSign来替代。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
        /// </summary>
        [JsonPropertyName("goods_sign")]
        public string GoodsSign { get; set; }

    }
    public partial class DiyRedPacketParamModel
    {

        /// <summary>
        /// 红包金额列表，200、300、500、1000、2000，单位分。红包金额和红包抵后价设置只能二选一，默认设置了红包金额会忽略红包抵后价设置
        /// </summary>
        [JsonPropertyName("amount_probability")]
        public List<long?> AmountProbability { get; set; }

        /// <summary>
        /// 设置玩法，false-现金红包, true-现金券
        /// </summary>
        [JsonPropertyName("dis_text")]
        public bool? DisText { get; set; }

        /// <summary>
        /// 推广页设置，false-红包开启页, true-红包领取页
        /// </summary>
        [JsonPropertyName("not_show_background")]
        public bool? NotShowBackground { get; set; }

        /// <summary>
        /// 优先展示类目
        /// </summary>
        [JsonPropertyName("opt_id")]
        public int? OptId { get; set; }

        /// <summary>
        /// 自定义红包抵后价和商品佣金区间对象数组
        /// </summary>
        [JsonPropertyName("range_items")]
        public List<RangeItemsModel> RangeItems { get; set; }
        public partial class RangeItemsModel
        {

            /// <summary>
            /// 区间的开始值
            /// </summary>
            [JsonPropertyName("range_from")]
            public long? RangeFrom { get; set; }

            /// <summary>
            /// range_id为1表示红包抵后价（单位分）， range_id为2表示佣金比例（单位千分之几)
            /// </summary>
            [JsonPropertyName("range_id")]
            public int? RangeId { get; set; }

            /// <summary>
            /// 区间的结束值
            /// </summary>
            [JsonPropertyName("range_to")]
            public long? RangeTo { get; set; }

        }

    }
    public partial class DiySpRedPacketParamModel
    {

        /// <summary>
        /// 商品goodsSign，支持通过goodsSign置顶落地页商品。使用说明：https://jinbao.pinduoduo.com/qa-system?questionId=252
        /// </summary>
        [JsonPropertyName("goods_sign")]
        public string GoodsSign { get; set; }

    }
    public partial class ExtParamsModel
    {

        /// <summary>
        /// 扩展参数Key
        /// </summary>
        [JsonPropertyName("$key")]
        public string Key { get; set; }

        /// <summary>
        /// 扩展参数Value
        /// </summary>
        [JsonPropertyName("$value")]
        public string Value { get; set; }

    }
    public partial class TmccParamModel
    {

        /// <summary>
        /// 置顶商品的goodsSign列表
        /// </summary>
        [JsonPropertyName("goods_signs")]
        public List<string> GoodsSigns { get; set; }

        /// <summary>
        /// 指定活动id
        /// </summary>
        [JsonPropertyName("tmc_config_id")]
        public long? TmcConfigId { get; set; }

    }

}

