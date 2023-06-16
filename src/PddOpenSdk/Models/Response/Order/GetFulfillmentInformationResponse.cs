namespace PddOpenSdk.Models.Response.Order;
public partial class GetFulfillmentInformationResponse : PddResponseModel
{

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("fulfillment_info_get_response")]
    public FulfillmentInfoGetResponseResponse FulfillmentInfoGetResponse { get; set; }
    public partial class FulfillmentInfoGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 详情信息
        /// </summary>
        [JsonPropertyName("fulfillment_info")]
        public FulfillmentInfoResponse FulfillmentInfo { get; set; }
        public partial class FulfillmentInfoResponse : PddResponseModel
        {

            /// <summary>
            /// 收件地城市
            /// </summary>
            [JsonPropertyName("city")]
            public string City { get; set; }

            /// <summary>
            /// 城市编码
            /// </summary>
            [JsonPropertyName("city_id")]
            public int? CityId { get; set; }

            /// <summary>
            /// 成交时间。格式yyyy-MM-dd HH:mm:ss
            /// </summary>
            [JsonPropertyName("confirm_time")]
            public string ConfirmTime { get; set; }

            /// <summary>
            /// 上门揽件信息
            /// </summary>
            [JsonPropertyName("door_to_door_collect_info")]
            public DoorToDoorCollectInfoResponse DoorToDoorCollectInfo { get; set; }

            /// <summary>
            /// 跨境全托管发货单号
            /// </summary>
            [JsonPropertyName("fulfillment_sn")]
            public string FulfillmentSn { get; set; }

            /// <summary>
            /// 跨境全托管发货单状态。1-待发货，2-已发货待签收，3-已签收
            /// </summary>
            [JsonPropertyName("fulfillment_status")]
            public int? FulfillmentStatus { get; set; }

            /// <summary>
            /// 托管发货单标签列表，courier_door_to_door_collect=快递上门揽收
            /// </summary>
            [JsonPropertyName("fulfillment_tag_list")]
            public List<FulfillmentTagListResponse> FulfillmentTagList { get; set; }

            /// <summary>
            /// 商品数量
            /// </summary>
            [JsonPropertyName("goods_count")]
            public int? GoodsCount { get; set; }

            /// <summary>
            /// 商品编号
            /// </summary>
            [JsonPropertyName("goods_id")]
            public long? GoodsId { get; set; }

            /// <summary>
            /// 商品图片
            /// </summary>
            [JsonPropertyName("goods_img")]
            public string GoodsImg { get; set; }

            /// <summary>
            /// 商品名称
            /// </summary>
            [JsonPropertyName("goods_name")]
            public string GoodsName { get; set; }

            /// <summary>
            /// 商品销售价格。单位：元
            /// </summary>
            [JsonPropertyName("goods_price")]
            public string GoodsPrice { get; set; }

            /// <summary>
            /// 快递公司编号
            /// </summary>
            [JsonPropertyName("logistics_id")]
            public long? LogisticsId { get; set; }

            /// <summary>
            /// 商家外部商品编码
            /// </summary>
            [JsonPropertyName("out_goods_sn")]
            public string OutGoodsSn { get; set; }

            /// <summary>
            /// 商家外部sku编码
            /// </summary>
            [JsonPropertyName("out_sku_sn")]
            public string OutSkuSn { get; set; }

            /// <summary>
            /// 承诺送达时间。格式yyyy-MM-dd HH:mm:ss
            /// </summary>
            [JsonPropertyName("promise_delivery_time")]
            public string PromiseDeliveryTime { get; set; }

            /// <summary>
            /// 收件地省份
            /// </summary>
            [JsonPropertyName("province")]
            public string Province { get; set; }

            /// <summary>
            /// 省份编码
            /// </summary>
            [JsonPropertyName("province_id")]
            public int? ProvinceId { get; set; }

            /// <summary>
            /// 收件人地址，不拼接省市区
            /// </summary>
            [JsonPropertyName("receiver_address")]
            public string ReceiverAddress { get; set; }

            /// <summary>
            /// 收件人姓名
            /// </summary>
            [JsonPropertyName("receiver_name")]
            public string ReceiverName { get; set; }

            /// <summary>
            /// 收件人电话
            /// </summary>
            [JsonPropertyName("receiver_phone")]
            public string ReceiverPhone { get; set; }

            /// <summary>
            /// 发货时间。格式yyyy-MM-dd HH:mm:ss
            /// </summary>
            [JsonPropertyName("shipping_time")]
            public string ShippingTime { get; set; }

            /// <summary>
            /// 商品规格编码
            /// </summary>
            [JsonPropertyName("sku_id")]
            public long? SkuId { get; set; }

            /// <summary>
            /// 商品规格，使用（规格值1,规格值2）组合作为sku的表示，中间以英文逗号隔开
            /// </summary>
            [JsonPropertyName("spec")]
            public string Spec { get; set; }

            /// <summary>
            /// 收件地区县
            /// </summary>
            [JsonPropertyName("town")]
            public string Town { get; set; }

            /// <summary>
            /// 区县编码
            /// </summary>
            [JsonPropertyName("town_id")]
            public int? TownId { get; set; }

            /// <summary>
            /// 快递运单号
            /// </summary>
            [JsonPropertyName("tracking_number")]
            public string TrackingNumber { get; set; }

            /// <summary>
            /// 更新时间。格式yyyy-MM-dd HH:mm:ss
            /// </summary>
            [JsonPropertyName("updated_at")]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// 承诺发货时间。格式yyyy-MM-dd HH:mm:ss
            /// </summary>
            [JsonPropertyName("promise_shipping_time")]
            public string PromiseShippingTime { get; set; }
            public partial class DoorToDoorCollectInfoResponse : PddResponseModel
            {

                /// <summary>
                /// 取号面单的快递公司编号
                /// </summary>
                [JsonPropertyName("waybill_logistics_id")]
                public long? WaybillLogisticsId { get; set; }

                /// <summary>
                /// 取号面单号
                /// </summary>
                [JsonPropertyName("waybill_sn")]
                public string WaybillSn { get; set; }

            }
            public partial class FulfillmentTagListResponse : PddResponseModel
            {

                /// <summary>
                /// 标签名称
                /// </summary>
                [JsonPropertyName("name")]
                public string Name { get; set; }

                /// <summary>
                /// 是否有标签：0=无标签，1=有标签
                /// </summary>
                [JsonPropertyName("value")]
                public int? Value { get; set; }

            }

        }

    }

}

