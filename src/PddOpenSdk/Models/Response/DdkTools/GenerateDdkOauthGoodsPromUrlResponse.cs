namespace PddOpenSdk.Models.Response.DdkTools;
public partial class GenerateDdkOauthGoodsPromUrlResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("goods_promotion_url_generate_response")]
    public GoodsPromotionUrlGenerateResponseResponse GoodsPromotionUrlGenerateResponse { get; set; }
    public partial class GoodsPromotionUrlGenerateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 多多进宝推广链接对象列表
        /// </summary>
        [JsonPropertyName("goods_promotion_url_list")]
        public List<GoodsPromotionUrlListResponse> GoodsPromotionUrlList { get; set; }
        public partial class GoodsPromotionUrlListResponse : PddResponseModel
        {

            /// <summary>
            /// 对应出参mobile_url的短链接，与mobile_url功能一致。
            /// </summary>
            [JsonPropertyName("mobile_short_url")]
            public string MobileShortUrl { get; set; }

            /// <summary>
            /// 使用此推广链接，用户安装微信的情况下，默认拉起拼多多福利券微信小程序，否则唤起H5页面
            /// </summary>
            [JsonPropertyName("mobile_url")]
            public string MobileUrl { get; set; }

            /// <summary>
            /// qq小程序信息
            /// </summary>
            [JsonPropertyName("qq_app_info")]
            public QqAppInfoResponse QqAppInfo { get; set; }

            /// <summary>
            /// 使用此推广链接，用户安装拼多多APP的情况下会唤起APP（需客户端支持schema跳转协议）
            /// </summary>
            [JsonPropertyName("schema_url")]
            public string SchemaUrl { get; set; }

            /// <summary>
            /// 对应出参url的短链接，与url功能一致
            /// </summary>
            [JsonPropertyName("short_url")]
            public string ShortUrl { get; set; }

            /// <summary>
            /// 使用此推广链接，用户安装多多团长APP的情况下会唤起APP（需客户端支持schema跳转协议）
            /// </summary>
            [JsonPropertyName("tz_schema_url")]
            public string TzSchemaUrl { get; set; }

            /// <summary>
            /// 普通推广长链接，唤起H5页面
            /// </summary>
            [JsonPropertyName("url")]
            public string Url { get; set; }

            /// <summary>
            /// 拼多多福利券微信小程序信息
            /// </summary>
            [JsonPropertyName("we_app_info")]
            public WeAppInfoResponse WeAppInfo { get; set; }
            public partial class QqAppInfoResponse : PddResponseModel
            {

                /// <summary>
                /// 拼多多小程序id
                /// </summary>
                [JsonPropertyName("app_id")]
                public string AppId { get; set; }

                /// <summary>
                /// Banner图
                /// </summary>
                [JsonPropertyName("banner_url")]
                public string BannerUrl { get; set; }

                /// <summary>
                /// 描述
                /// </summary>
                [JsonPropertyName("desc")]
                public string Desc { get; set; }

                /// <summary>
                /// 小程序path值
                /// </summary>
                [JsonPropertyName("page_path")]
                public string PagePath { get; set; }

                /// <summary>
                /// 小程序icon
                /// </summary>
                [JsonPropertyName("qq_app_icon_url")]
                public string QqAppIconUrl { get; set; }

                /// <summary>
                /// 来源名
                /// </summary>
                [JsonPropertyName("source_display_name")]
                public string SourceDisplayName { get; set; }

                /// <summary>
                /// 小程序标题
                /// </summary>
                [JsonPropertyName("title")]
                public string Title { get; set; }

                /// <summary>
                /// 用户名
                /// </summary>
                [JsonPropertyName("user_name")]
                public string UserName { get; set; }

            }
            public partial class WeAppInfoResponse : PddResponseModel
            {

                /// <summary>
                /// 小程序id
                /// </summary>
                [JsonPropertyName("app_id")]
                public string AppId { get; set; }

                /// <summary>
                /// Banner图
                /// </summary>
                [JsonPropertyName("banner_url")]
                public string BannerUrl { get; set; }

                /// <summary>
                /// 描述
                /// </summary>
                [JsonPropertyName("desc")]
                public string Desc { get; set; }

                /// <summary>
                /// 小程序path值
                /// </summary>
                [JsonPropertyName("page_path")]
                public string PagePath { get; set; }

                /// <summary>
                /// 来源名
                /// </summary>
                [JsonPropertyName("source_display_name")]
                public string SourceDisplayName { get; set; }

                /// <summary>
                /// 小程序标题
                /// </summary>
                [JsonPropertyName("title")]
                public string Title { get; set; }

                /// <summary>
                /// 用户名
                /// </summary>
                [JsonPropertyName("user_name")]
                public string UserName { get; set; }

                /// <summary>
                /// 小程序图片
                /// </summary>
                [JsonPropertyName("we_app_icon_url")]
                public string WeAppIconUrl { get; set; }

            }

        }

    }

}

