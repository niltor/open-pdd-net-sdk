namespace PddOpenSdk.Models.Response.DdkTools;
public partial class GenerateDdkOauthCmsPromUrlResponse : PddResponseModel
{

    /// <summary>
    /// 商城推广链接返回对象
    /// </summary>
    [JsonPropertyName("cms_promotion_url_generate_response")]
    public CmsPromotionUrlGenerateResponseResponse CmsPromotionUrlGenerateResponse { get; set; }
    public partial class CmsPromotionUrlGenerateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// total
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 链接列表
        /// </summary>
        [JsonPropertyName("url_list")]
        public List<UrlListResponse> UrlList { get; set; }
        public partial class UrlListResponse : PddResponseModel
        {

            /// <summary>
            /// 唤醒拼多多app短链
            /// </summary>
            [JsonPropertyName("mobile_short_url")]
            public string MobileShortUrl { get; set; }

            /// <summary>
            /// 唤醒拼多多app链接
            /// </summary>
            [JsonPropertyName("mobile_url")]
            public string MobileUrl { get; set; }

            /// <summary>
            /// 多人团唤醒拼多多app链接
            /// </summary>
            [JsonPropertyName("multi_group_mobile_short_url")]
            public string MultiGroupMobileShortUrl { get; set; }

            /// <summary>
            /// 多人团唤醒拼多多app长链接
            /// </summary>
            [JsonPropertyName("multi_group_mobile_url")]
            public string MultiGroupMobileUrl { get; set; }

            /// <summary>
            /// 多人团短链，唤起H5页面
            /// </summary>
            [JsonPropertyName("multi_group_short_url")]
            public string MultiGroupShortUrl { get; set; }

            /// <summary>
            /// 多人团长链，唤起H5页面
            /// </summary>
            [JsonPropertyName("multi_group_url")]
            public string MultiGroupUrl { get; set; }

            /// <summary>
            /// 双人团链接列表
            /// </summary>
            [JsonPropertyName("multi_url_list")]
            public MultiUrlListResponse MultiUrlList { get; set; }

            /// <summary>
            /// h5短链接
            /// </summary>
            [JsonPropertyName("short_url")]
            public string ShortUrl { get; set; }

            /// <summary>
            /// CPSsign
            /// </summary>
            [JsonPropertyName("sign")]
            public string Sign { get; set; }

            /// <summary>
            /// 单人团链接列表
            /// </summary>
            [JsonPropertyName("single_url_list")]
            public SingleUrlListResponse SingleUrlList { get; set; }

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
            public partial class MultiUrlListResponse : PddResponseModel
            {

                /// <summary>
                /// 双人团唤醒拼多多app短链接
                /// </summary>
                [JsonPropertyName("mobile_short_url")]
                public string MobileShortUrl { get; set; }

                /// <summary>
                /// 双人团唤醒拼多多app长链接
                /// </summary>
                [JsonPropertyName("mobile_url")]
                public string MobileUrl { get; set; }

                /// <summary>
                /// schema链接，用户安装拼多多APP的情况下会唤起APP（需客户端支持schema跳转协议）
                /// </summary>
                [JsonPropertyName("schema_url")]
                public string SchemaUrl { get; set; }

                /// <summary>
                /// 双人团短链接
                /// </summary>
                [JsonPropertyName("short_url")]
                public string ShortUrl { get; set; }

                /// <summary>
                /// 双人团长链接，唤起H5页面
                /// </summary>
                [JsonPropertyName("url")]
                public string Url { get; set; }

            }
            public partial class SingleUrlListResponse : PddResponseModel
            {

                /// <summary>
                /// 唤醒拼多多app短链接
                /// </summary>
                [JsonPropertyName("mobile_short_url")]
                public string MobileShortUrl { get; set; }

                /// <summary>
                /// 唤醒拼多多app长链接
                /// </summary>
                [JsonPropertyName("mobile_url")]
                public string MobileUrl { get; set; }

                /// <summary>
                /// schema链接，用户安装拼多多APP的情况下会唤起APP（需客户端支持schema跳转协议）
                /// </summary>
                [JsonPropertyName("schema_url")]
                public string SchemaUrl { get; set; }

                /// <summary>
                /// 对应出参url的短链接，与url功能一致。
                /// </summary>
                [JsonPropertyName("short_url")]
                public string ShortUrl { get; set; }

                /// <summary>
                /// 普通推广长链接，唤起H5页面
                /// </summary>
                [JsonPropertyName("url")]
                public string Url { get; set; }

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

