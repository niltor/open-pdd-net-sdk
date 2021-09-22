using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.LogisticsCompany
{
    public partial class NotifyServiceMailBizactionRequestModel : PddRequestModel
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [JsonProperty("request")]
        public RequestRequestModel Request { get; set; }
        public partial class RequestRequestModel : PddRequestModel
        {
            /// <summary>
            /// 扩展信息，json格式
            /// </summary>
            [JsonProperty("attributes")]
            public string Attributes { get; set; }
            /// <summary>
            /// accept-接单， reject-拒单， dispatch-派单（需要小件员信息）， takePackage-已取件（需要有核重核价信息）， payed-支付完成 postmanCancel-小件员取消， expressCancel-快递公司取消 postMailNo-回传运单
            /// </summary>
            [JsonProperty("bizAction")]
            public string BizAction { get; set; }
            /// <summary>
            /// 服务明细描述信息
            /// </summary>
            [JsonProperty("bizActionDesc")]
            public string BizActionDesc { get; set; }
            /// <summary>
            /// 取消原因
            /// </summary>
            [JsonProperty("cancelOrRejectReason")]
            public string CancelOrRejectReason { get; set; }
            /// <summary>
            /// 核价金额，单位分
            /// </summary>
            [JsonProperty("checkPrice")]
            public int? CheckPrice { get; set; }
            /// <summary>
            /// 核重重量，单位克
            /// </summary>
            [JsonProperty("checkWeight")]
            public int? CheckWeight { get; set; }
            /// <summary>
            /// 改约结束时间- changeAppoint必填
            /// </summary>
            [JsonProperty("endTime")]
            public string EndTime { get; set; }
            /// <summary>
            /// 业务实操时间
            /// </summary>
            [JsonProperty("executeTime")]
            public string ExecuteTime { get; set; }
            /// <summary>
            /// 柜子编号
            /// </summary>
            [JsonProperty("expressBoxCode")]
            public string ExpressBoxCode { get; set; }
            /// <summary>
            /// 物流公司编码
            /// </summary>
            [JsonProperty("expressCode")]
            public string ExpressCode { get; set; }
            /// <summary>
            /// 运费金额
            /// </summary>
            [JsonProperty("freightPrice")]
            public int? FreightPrice { get; set; }
            /// <summary>
            /// 保费，单位分
            /// </summary>
            [JsonProperty("insurancePrice")]
            public int? InsurancePrice { get; set; }
            /// <summary>
            /// 报价金额，单位分
            /// </summary>
            [JsonProperty("insuranceValue")]
            public int? InsuranceValue { get; set; }
            /// <summary>
            /// 运单号
            /// </summary>
            [JsonProperty("mailNo")]
            public string MailNo { get; set; }
            /// <summary>
            /// 寄件订单单号
            /// </summary>
            [JsonProperty("mailOrderSn")]
            public string MailOrderSn { get; set; }
            /// <summary>
            /// 其他费用，单位分
            /// </summary>
            [JsonProperty("otherPrice")]
            public int? OtherPrice { get; set; }
            /// <summary>
            /// 包装费用，单位分
            /// </summary>
            [JsonProperty("packagePrice")]
            public int? PackagePrice { get; set; }
            /// <summary>
            /// 支付金额，单位分
            /// </summary>
            [JsonProperty("payPrice")]
            public int? PayPrice { get; set; }
            /// <summary>
            /// 取件码
            /// </summary>
            [JsonProperty("pickCode")]
            public string PickCode { get; set; }
            /// <summary>
            /// 小件员code
            /// </summary>
            [JsonProperty("postmanCode")]
            public string PostmanCode { get; set; }
            /// <summary>
            /// 小件员姓名
            /// </summary>
            [JsonProperty("postmanName")]
            public string PostmanName { get; set; }
            /// <summary>
            /// 小件员电话
            /// </summary>
            [JsonProperty("postmanPhone")]
            public string PostmanPhone { get; set; }
            /// <summary>
            /// 寄件类型，HOME_DELIVERY-上门取件
            /// </summary>
            [JsonProperty("postType")]
            public string PostType { get; set; }
            /// <summary>
            /// 取消原因code
            /// </summary>
            [JsonProperty("reasonCode")]
            public string ReasonCode { get; set; }
            /// <summary>
            /// 改约开始时间- changeAppoint节点必填
            /// </summary>
            [JsonProperty("startTime")]
            public string StartTime { get; set; }
            /// <summary>
            /// 滞留原因
            /// </summary>
            [JsonProperty("retentionReason")]
            public string RetentionReason { get; set; }
            /// <summary>
            /// 小件员修改后的收件人信息
            /// </summary>
            [JsonProperty("modifyReceiverInfo")]
            public ModifyReceiverInfoRequestModel ModifyReceiverInfo { get; set; }
            public partial class ModifyReceiverInfoRequestModel : PddRequestModel
            {
                /// <summary>
                /// 详细地址
                /// </summary>
                [JsonProperty("addrDetail")]
                public string AddrDetail { get; set; }
                /// <summary>
                /// 区名称
                /// </summary>
                [JsonProperty("areaName")]
                public string AreaName { get; set; }
                /// <summary>
                /// 市名称
                /// </summary>
                [JsonProperty("cityName")]
                public string CityName { get; set; }
                /// <summary>
                /// 联系人姓名
                /// </summary>
                [JsonProperty("contactName")]
                public string ContactName { get; set; }
                /// <summary>
                /// 联系人手机号
                /// </summary>
                [JsonProperty("mobile")]
                public string Mobile { get; set; }
                /// <summary>
                /// 省名称
                /// </summary>
                [JsonProperty("provName")]
                public string ProvName { get; set; }
                /// <summary>
                /// 街道名称
                /// </summary>
                [JsonProperty("streetName")]
                public string StreetName { get; set; }
                /// <summary>
                /// 联系人电话号码
                /// </summary>
                [JsonProperty("telephone")]
                public string Telephone { get; set; }

            }

        }

    }

}
