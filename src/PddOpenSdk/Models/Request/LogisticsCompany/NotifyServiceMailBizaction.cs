namespace PddOpenSdk.Models.Request.LogisticsCompany;
public partial class NotifyServiceMailBizaction
{

    /// <summary>
    /// 请求参数
    /// </summary>
    [JsonPropertyName("request")]
    public RequestModel Request { get; set; }
    public partial class RequestModel
    {

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [JsonPropertyName("attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// accept-接单， reject-拒单， dispatch-派单（需要小件员信息）， takePackage-已取件（需要有核重核价信息）， payed-支付完成 postmanCancel-小件员取消， expressCancel-快递公司取消 postMailNo-回传运单
        /// </summary>
        [JsonPropertyName("bizAction")]
        public string BizAction { get; set; }

        /// <summary>
        /// 服务明细描述信息
        /// </summary>
        [JsonPropertyName("bizActionDesc")]
        public string BizActionDesc { get; set; }

        /// <summary>
        /// 取消原因
        /// </summary>
        [JsonPropertyName("cancelOrRejectReason")]
        public string CancelOrRejectReason { get; set; }

        /// <summary>
        /// 核价金额，单位分
        /// </summary>
        [JsonPropertyName("checkPrice")]
        public int? CheckPrice { get; set; }

        /// <summary>
        /// 核价方式（当前实操为checkWeightPrice时必填）： weight:按照重量核价； volume：按照体积核价
        /// </summary>
        [JsonPropertyName("checkPriceType")]
        public string CheckPriceType { get; set; }

        /// <summary>
        /// 核重重量，单位克
        /// </summary>
        [JsonPropertyName("checkWeight")]
        public int? CheckWeight { get; set; }

        /// <summary>
        /// 最终服务商确认的收件人信息
        /// </summary>
        [JsonPropertyName("confirmReceiverInfo")]
        public ConfirmReceiverInfoModel ConfirmReceiverInfo { get; set; }

        /// <summary>
        /// 最终服务商确认的寄件人信息
        /// </summary>
        [JsonPropertyName("confirmSenderInfo")]
        public ConfirmSenderInfoModel ConfirmSenderInfo { get; set; }

        /// <summary>
        /// 改约结束时间- changeAppoint必填
        /// </summary>
        [JsonPropertyName("endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// 业务实操时间
        /// </summary>
        [JsonPropertyName("executeTime")]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 柜子编号
        /// </summary>
        [JsonPropertyName("expressBoxCode")]
        public string ExpressBoxCode { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [JsonPropertyName("expressCode")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 运费金额
        /// </summary>
        [JsonPropertyName("freightPrice")]
        public int? FreightPrice { get; set; }

        /// <summary>
        /// 高度（当前核价方式为volume时必填），单位是厘米
        /// </summary>
        [JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 保费，单位分
        /// </summary>
        [JsonPropertyName("insurancePrice")]
        public int? InsurancePrice { get; set; }

        /// <summary>
        /// 报价金额，单位分
        /// </summary>
        [JsonPropertyName("insuranceValue")]
        public int? InsuranceValue { get; set; }

        /// <summary>
        /// 长度（当前核价方式为volume时必填），单位是厘米
        /// </summary>
        [JsonPropertyName("length")]
        public int? Length { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [JsonPropertyName("mailNo")]
        public string MailNo { get; set; }

        /// <summary>
        /// 寄件订单单号
        /// </summary>
        [JsonPropertyName("mailOrderSn")]
        public string MailOrderSn { get; set; }

        /// <summary>
        /// 小件员修改后的收件人信息
        /// </summary>
        [JsonPropertyName("modifyReceiverInfo")]
        public ModifyReceiverInfoModel ModifyReceiverInfo { get; set; }

        /// <summary>
        /// 其他费用，单位分
        /// </summary>
        [JsonPropertyName("otherPrice")]
        public int? OtherPrice { get; set; }

        /// <summary>
        /// 包装费用，单位分
        /// </summary>
        [JsonPropertyName("packagePrice")]
        public int? PackagePrice { get; set; }

        /// <summary>
        /// 支付金额，单位分
        /// </summary>
        [JsonPropertyName("payPrice")]
        public int? PayPrice { get; set; }

        /// <summary>
        /// 取件码
        /// </summary>
        [JsonPropertyName("pickCode")]
        public string PickCode { get; set; }

        /// <summary>
        /// 寄件类型，HOME_DELIVERY-上门取件
        /// </summary>
        [JsonPropertyName("postType")]
        public string PostType { get; set; }

        /// <summary>
        /// 小件员code
        /// </summary>
        [JsonPropertyName("postmanCode")]
        public string PostmanCode { get; set; }

        /// <summary>
        /// 小件员姓名
        /// </summary>
        [JsonPropertyName("postmanName")]
        public string PostmanName { get; set; }

        /// <summary>
        /// 小件员电话
        /// </summary>
        [JsonPropertyName("postmanPhone")]
        public string PostmanPhone { get; set; }

        /// <summary>
        /// 取消原因code
        /// </summary>
        [JsonPropertyName("reasonCode")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 滞留原因
        /// </summary>
        [JsonPropertyName("retentionReason")]
        public string RetentionReason { get; set; }

        /// <summary>
        /// 改约开始时间- changeAppoint节点必填
        /// </summary>
        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// 宽度（当前核价方式为volume时必填），单位是厘米
        /// </summary>
        [JsonPropertyName("width")]
        public int? Width { get; set; }
        public partial class ConfirmReceiverInfoModel
        {

            /// <summary>
            /// 详细地址
            /// </summary>
            [JsonPropertyName("addrDetail")]
            public string AddrDetail { get; set; }

            /// <summary>
            /// 区名称
            /// </summary>
            [JsonPropertyName("areaName")]
            public string AreaName { get; set; }

            /// <summary>
            /// 市名称
            /// </summary>
            [JsonPropertyName("cityName")]
            public string CityName { get; set; }

            /// <summary>
            /// 联系人姓名
            /// </summary>
            [JsonPropertyName("contactName")]
            public string ContactName { get; set; }

            /// <summary>
            /// 联系人手机号
            /// </summary>
            [JsonPropertyName("mobile")]
            public string Mobile { get; set; }

            /// <summary>
            /// 省名称
            /// </summary>
            [JsonPropertyName("provName")]
            public string ProvName { get; set; }

            /// <summary>
            /// 街道名称
            /// </summary>
            [JsonPropertyName("streetName")]
            public string StreetName { get; set; }

            /// <summary>
            /// 联系人电话号码
            /// </summary>
            [JsonPropertyName("telephone")]
            public string Telephone { get; set; }

        }
        public partial class ConfirmSenderInfoModel
        {

            /// <summary>
            /// 详细地址
            /// </summary>
            [JsonPropertyName("addrDetail")]
            public string AddrDetail { get; set; }

            /// <summary>
            /// 区名称
            /// </summary>
            [JsonPropertyName("areaName")]
            public string AreaName { get; set; }

            /// <summary>
            /// 市名称
            /// </summary>
            [JsonPropertyName("cityName")]
            public string CityName { get; set; }

            /// <summary>
            /// 联系人姓名
            /// </summary>
            [JsonPropertyName("contactName")]
            public string ContactName { get; set; }

            /// <summary>
            /// 联系人手机号
            /// </summary>
            [JsonPropertyName("mobile")]
            public string Mobile { get; set; }

            /// <summary>
            /// 省名称
            /// </summary>
            [JsonPropertyName("provName")]
            public string ProvName { get; set; }

            /// <summary>
            /// 街道名称
            /// </summary>
            [JsonPropertyName("streetName")]
            public string StreetName { get; set; }

            /// <summary>
            /// 联系人电话号码
            /// </summary>
            [JsonPropertyName("telephone")]
            public string Telephone { get; set; }

        }
        public partial class ModifyReceiverInfoModel
        {

            /// <summary>
            /// 详细地址
            /// </summary>
            [JsonPropertyName("addrDetail")]
            public string AddrDetail { get; set; }

            /// <summary>
            /// 区名称
            /// </summary>
            [JsonPropertyName("areaName")]
            public string AreaName { get; set; }

            /// <summary>
            /// 市名称
            /// </summary>
            [JsonPropertyName("cityName")]
            public string CityName { get; set; }

            /// <summary>
            /// 联系人姓名
            /// </summary>
            [JsonPropertyName("contactName")]
            public string ContactName { get; set; }

            /// <summary>
            /// 联系人手机号
            /// </summary>
            [JsonPropertyName("mobile")]
            public string Mobile { get; set; }

            /// <summary>
            /// 省名称
            /// </summary>
            [JsonPropertyName("provName")]
            public string ProvName { get; set; }

            /// <summary>
            /// 街道名称
            /// </summary>
            [JsonPropertyName("streetName")]
            public string StreetName { get; set; }

            /// <summary>
            /// 联系人电话号码
            /// </summary>
            [JsonPropertyName("telephone")]
            public string Telephone { get; set; }

        }

    }

}

