using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Erp
{
    public partial class GetOrderInformationResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("order_info_get_response")]
        public OrderInfoGetResponseResponseModel OrderInfoGetResponse { get; set; }
        public partial class OrderInfoGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 订单详情对象
            /// </summary>
            [JsonProperty("order_info")]
            public OrderInfoResponseModel OrderInfo { get; set; }
            public partial class OrderInfoResponseModel : PddResponseModel
            {
                /// <summary>
                /// 送货入户并安装 单位：元
                /// </summary>
                [JsonProperty("delivery_install_value")]
                public double DeliveryInstallValue { get; set; }
                /// <summary>
                /// 送货入户费用 单位：元
                /// </summary>
                [JsonProperty("delivery_home_value")]
                public double DeliveryHomeValue { get; set; }
                /// <summary>
                /// 上门安装费用 单位：元
                /// </summary>
                [JsonProperty("home_install_value")]
                public double HomeInstallValue { get; set; }
                /// <summary>
                /// 身份证姓名
                /// </summary>
                [JsonProperty("id_card_name")]
                public string IdCardName { get; set; }
                /// <summary>
                /// 身份证号码
                /// </summary>
                [JsonProperty("id_card_num")]
                public string IdCardNum { get; set; }
                /// <summary>
                /// 成交状态：0：未成交、1：已成交、2：已取消、-1：全部
                /// </summary>
                [JsonProperty("confirm_status")]
                public int ConfirmStatus { get; set; }
                /// <summary>
                /// 成团状态：0：拼团中、1：已成团、2：团失败、-1：全部
                /// </summary>
                [JsonProperty("group_status")]
                public int GroupStatus { get; set; }
                /// <summary>
                /// 定金订单信息 ，非定金订单该字段为null
                /// </summary>
                [JsonProperty("step_order_info")]
                public StepOrderInfoResponseModel StepOrderInfo { get; set; }
                /// <summary>
                /// 订单类型 0-普通订单、1-定金订单
                /// </summary>
                [JsonProperty("trade_type")]
                public int TradeType { get; set; }
                /// <summary>
                /// 仓库信息
                /// </summary>
                [JsonProperty("order_depot_info")]
                public OrderDepotInfoResponseModel OrderDepotInfo { get; set; }
                /// <summary>
                /// 支付时间
                /// </summary>
                [JsonProperty("pay_time")]
                public string PayTime { get; set; }
                /// <summary>
                /// 全国联保，1:是，0:否
                /// </summary>
                [JsonProperty("support_nationwide_warranty")]
                public int SupportNationwideWarranty { get; set; }
                /// <summary>
                /// 退货包运费，1:是，0:否
                /// </summary>
                [JsonProperty("return_freight_payer")]
                public int ReturnFreightPayer { get; set; }
                /// <summary>
                /// 只换不修，1:是，0:否
                /// </summary>
                [JsonProperty("only_support_replace")]
                public int OnlySupportReplace { get; set; }
                /// <summary>
                /// 列表
                /// </summary>
                [JsonProperty("card_info_list")]
                public List<string> CardInfoList { get; set; }
                /// <summary>
                /// 快递形式
                /// </summary>
                [JsonProperty("home_delivery_type")]
                public int HomeDeliveryType { get; set; }
                /// <summary>
                /// 是否顺丰包邮 1表示是 0表示否
                /// </summary>
                [JsonProperty("free_sf")]
                public int FreeSf { get; set; }
                /// <summary>
                /// 售后状态  0：无售后 2：买家申请退款，待商家处理 3：退货退款，待商家处理 4：商家同意退款，退款中 5：平台同意退款，退款中 6：驳回退款， 待买家处理 7：已同意退货退款,待用户发货 8：平台处理中 9：平台拒 绝退款，退款关闭 10：退款成功 11：买家撤销 12：买家逾期未处 理，退款失败 13：买家逾期，超过有效期 14 : 换货补寄待商家处理 15:换货补寄待用户处理 16:换货补寄成功 17:换货补寄失败 18:换货补寄待用户确认完成
                /// </summary>
                [JsonProperty("after_sales_status")]
                public int AfterSalesStatus { get; set; }
                /// <summary>
                /// 预售时间
                /// </summary>
                [JsonProperty("pre_sale_time")]
                public string PreSaleTime { get; set; }
                /// <summary>
                /// 是否为预售商品 1表示是 0表示否
                /// </summary>
                [JsonProperty("is_pre_sale")]
                public int IsPreSale { get; set; }
                /// <summary>
                /// 1代表有 0代表无
                /// </summary>
                [JsonProperty("invoice_status")]
                public int InvoiceStatus { get; set; }
                /// <summary>
                /// 买家留言信息
                /// </summary>
                [JsonProperty("buyer_memo")]
                public string BuyerMemo { get; set; }
                /// <summary>
                /// 支付申报订单号
                /// </summary>
                [JsonProperty("inner_transaction_id")]
                public string InnerTransactionId { get; set; }
                /// <summary>
                /// 商品一级分类
                /// </summary>
                [JsonProperty("cat_id_1")]
                public long CatId1 { get; set; }
                /// <summary>
                /// 商品二级分类
                /// </summary>
                [JsonProperty("cat_id_2")]
                public long CatId2 { get; set; }
                /// <summary>
                /// 商品三级分类
                /// </summary>
                [JsonProperty("cat_id_3")]
                public long CatId3 { get; set; }
                /// <summary>
                /// 商品四级分类
                /// </summary>
                [JsonProperty("cat_id_4")]
                public long CatId4 { get; set; }
                /// <summary>
                /// 缺货处理状态
                /// </summary>
                [JsonProperty("stock_out_handle_status")]
                public int StockOutHandleStatus { get; set; }
                /// <summary>
                /// 是否缺货
                /// </summary>
                [JsonProperty("is_stock_out")]
                public int IsStockOut { get; set; }
                /// <summary>
                /// 国家编码
                /// </summary>
                [JsonProperty("country_id")]
                public int CountryId { get; set; }
                /// <summary>
                /// 省份编码
                /// </summary>
                [JsonProperty("province_id")]
                public int ProvinceId { get; set; }
                /// <summary>
                /// 城市编码
                /// </summary>
                [JsonProperty("city_id")]
                public int CityId { get; set; }
                /// <summary>
                /// 区县编码
                /// </summary>
                [JsonProperty("town_id")]
                public int TownId { get; set; }
                /// <summary>
                /// 确认收货时间
                /// </summary>
                [JsonProperty("receive_time")]
                public string ReceiveTime { get; set; }
                /// <summary>
                /// 订单编号
                /// </summary>
                [JsonProperty("order_sn")]
                public string OrderSn { get; set; }
                /// <summary>
                /// 成团时间
                /// </summary>
                [JsonProperty("confirm_time")]
                public string ConfirmTime { get; set; }
                /// <summary>
                /// 创建时间
                /// </summary>
                [JsonProperty("created_time")]
                public string CreatedTime { get; set; }
                /// <summary>
                /// 收件地国家
                /// </summary>
                [JsonProperty("country")]
                public string Country { get; set; }
                /// <summary>
                /// 收件地省份
                /// </summary>
                [JsonProperty("province")]
                public string Province { get; set; }
                /// <summary>
                /// 收件地城市
                /// </summary>
                [JsonProperty("city")]
                public string City { get; set; }
                /// <summary>
                /// 收件地区县
                /// </summary>
                [JsonProperty("town")]
                public string Town { get; set; }
                /// <summary>
                /// 收件详细地址
                /// </summary>
                [JsonProperty("address")]
                public string Address { get; set; }
                /// <summary>
                /// 收件人姓名
                /// </summary>
                [JsonProperty("receiver_name")]
                public string ReceiverName { get; set; }
                /// <summary>
                /// 收件人电话，仅订单状态为待发货状态下返回明文，其他状态下返回脱敏手机号，例如“1387677****”
                /// </summary>
                [JsonProperty("receiver_phone")]
                public string ReceiverPhone { get; set; }
                /// <summary>
                /// 支付金额（元）支付金额=商品金额-折扣金额+邮费
                /// </summary>
                [JsonProperty("pay_amount")]
                public double PayAmount { get; set; }
                /// <summary>
                /// 商品金额（元）商品金额=商品销售价格*商品数量-改价金额（接口暂无该字段）
                /// </summary>
                [JsonProperty("goods_amount")]
                public double GoodsAmount { get; set; }
                /// <summary>
                /// 折扣金额（元）折扣金额=平台优惠+商家优惠+团长免单优惠金额
                /// </summary>
                [JsonProperty("discount_amount")]
                public double DiscountAmount { get; set; }
                /// <summary>
                /// 支付单号
                /// </summary>
                [JsonProperty("pay_no")]
                public string PayNo { get; set; }
                /// <summary>
                /// 邮费
                /// </summary>
                [JsonProperty("postage")]
                public double Postage { get; set; }
                /// <summary>
                /// 支付方式，枚举值：QQ,WEIXIN,ALIPAY
                /// </summary>
                [JsonProperty("pay_type")]
                public string PayType { get; set; }
                /// <summary>
                /// 快递公司编号
                /// </summary>
                [JsonProperty("logistics_id")]
                public long LogisticsId { get; set; }
                /// <summary>
                /// 快递运单号
                /// </summary>
                [JsonProperty("tracking_number")]
                public string TrackingNumber { get; set; }
                /// <summary>
                /// 发货时间
                /// </summary>
                [JsonProperty("shipping_time")]
                public string ShippingTime { get; set; }
                /// <summary>
                /// 发货状态，枚举值：1：待发货，2：已发货待签收，3：已签收
                /// </summary>
                [JsonProperty("order_status")]
                public int OrderStatus { get; set; }
                /// <summary>
                /// 是否抽奖订单，1-非抽奖订单，2-抽奖订单
                /// </summary>
                [JsonProperty("is_lucky_flag")]
                public int IsLuckyFlag { get; set; }
                /// <summary>
                /// 退款状态，枚举值：1：无售后或售后关闭，2：售后处理中，3：退款中，4： 退款成功
                /// </summary>
                [JsonProperty("refund_status")]
                public int RefundStatus { get; set; }
                /// <summary>
                /// 订单最近一次更新时间
                /// </summary>
                [JsonProperty("updated_at")]
                public string UpdatedAt { get; set; }
                /// <summary>
                /// 订单承诺发货时间
                /// </summary>
                [JsonProperty("last_ship_time")]
                public string LastShipTime { get; set; }
                /// <summary>
                /// 商家订单备注
                /// </summary>
                [JsonProperty("remark")]
                public string Remark { get; set; }
                /// <summary>
                /// 订单中商品sku列表
                /// </summary>
                [JsonProperty("item_list")]
                public List<ItemListResponseModel> ItemList { get; set; }
                /// <summary>
                /// 平台优惠金额
                /// </summary>
                [JsonProperty("platform_discount")]
                public double PlatformDiscount { get; set; }
                /// <summary>
                /// 店铺优惠金额
                /// </summary>
                [JsonProperty("seller_discount")]
                public double SellerDiscount { get; set; }
                /// <summary>
                /// 团长免单优惠金额，只在团长免单活动中才会返回优惠金额
                /// </summary>
                [JsonProperty("capital_free_discount")]
                public double CapitalFreeDiscount { get; set; }
                public partial class StepOrderInfoResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 已付定金 单位：元
                    /// </summary>
                    [JsonProperty("advanced_paid_fee")]
                    public double AdvancedPaidFee { get; set; }
                    /// <summary>
                    /// 分阶段已付金额（定金+尾款） 单位：元
                    /// </summary>
                    [JsonProperty("step_paid_fee")]
                    public double StepPaidFee { get; set; }
                    /// <summary>
                    /// 膨胀金额 （包含券减） 单位：元
                    /// </summary>
                    [JsonProperty("step_discount_amount")]
                    public double StepDiscountAmount { get; set; }
                    /// <summary>
                    /// 定金订单状态：step_trade_status 枚举：0-定金未付尾款未付、1-定金已付尾款未付、2-定金已付尾款已付
                    /// </summary>
                    [JsonProperty("step_trade_status")]
                    public int StepTradeStatus { get; set; }

                }
                public partial class OrderDepotInfoResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 子货品列表（组合货品才会有子货品信息）
                    /// </summary>
                    [JsonProperty("ware_sub_info_list")]
                    public List<WareSubInfoListResponseModel> WareSubInfoList { get; set; }
                    /// <summary>
                    /// 货品编码
                    /// </summary>
                    [JsonProperty("ware_sn")]
                    public string WareSn { get; set; }
                    /// <summary>
                    /// 货品类型（0：普通货品，1：组合货品）
                    /// </summary>
                    [JsonProperty("ware_type")]
                    public int WareType { get; set; }
                    /// <summary>
                    /// 货品名称
                    /// </summary>
                    [JsonProperty("ware_name")]
                    public string WareName { get; set; }
                    /// <summary>
                    /// 货品id
                    /// </summary>
                    [JsonProperty("ware_id")]
                    public string WareId { get; set; }
                    /// <summary>
                    /// 仓库编码
                    /// </summary>
                    [JsonProperty("depot_code")]
                    public string DepotCode { get; set; }
                    /// <summary>
                    /// 仓库名称
                    /// </summary>
                    [JsonProperty("depot_name")]
                    public string DepotName { get; set; }
                    /// <summary>
                    /// 仓库id
                    /// </summary>
                    [JsonProperty("depot_id")]
                    public string DepotId { get; set; }
                    public partial class WareSubInfoListResponseModel : PddResponseModel
                    {
                        /// <summary>
                        /// 子货品id
                        /// </summary>
                        [JsonProperty("ware_id")]
                        public long WareId { get; set; }
                        /// <summary>
                        /// 子货品编码
                        /// </summary>
                        [JsonProperty("ware_sn")]
                        public string WareSn { get; set; }
                        /// <summary>
                        /// 子货品数量
                        /// </summary>
                        [JsonProperty("ware_quantity")]
                        public long WareQuantity { get; set; }
                        /// <summary>
                        /// 子货品1编码
                        /// </summary>
                        [JsonProperty("ware_name")]
                        public string WareName { get; set; }

                    }

                }
                public partial class ItemListResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 商品编号
                    /// </summary>
                    [JsonProperty("goods_id")]
                    public long GoodsId { get; set; }
                    /// <summary>
                    /// 商品规格编码
                    /// </summary>
                    [JsonProperty("sku_id")]
                    public long SkuId { get; set; }
                    /// <summary>
                    /// 商家外部编码（sku），注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
                    /// </summary>
                    [JsonProperty("outer_id")]
                    public string OuterId { get; set; }
                    /// <summary>
                    /// 商家外部编码（商品），注意：编辑商品后必须等待商品审核通过后方可生效，订单中商品信息为交易快照的商品信息。
                    /// </summary>
                    [JsonProperty("outer_goods_id")]
                    public string OuterGoodsId { get; set; }
                    /// <summary>
                    /// 商品名称
                    /// </summary>
                    [JsonProperty("goods_name")]
                    public string GoodsName { get; set; }
                    /// <summary>
                    /// 商品销售价格
                    /// </summary>
                    [JsonProperty("goods_price")]
                    public double GoodsPrice { get; set; }
                    /// <summary>
                    /// 商品规格，使用（规格值1,规格值2）组合作为sku的表示，中间以英文逗号隔开
                    /// </summary>
                    [JsonProperty("goods_spec")]
                    public string GoodsSpec { get; set; }
                    /// <summary>
                    /// 商品数量
                    /// </summary>
                    [JsonProperty("goods_count")]
                    public int GoodsCount { get; set; }
                    /// <summary>
                    /// 商品图片
                    /// </summary>
                    [JsonProperty("goods_img")]
                    public string GoodsImg { get; set; }

                }

            }

        }

    }

}
