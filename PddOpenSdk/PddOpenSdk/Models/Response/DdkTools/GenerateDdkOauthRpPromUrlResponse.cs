namespace PddOpenSdk.Models.Response.DdkTools;
public partial class GenerateDdkOauthRpPromUrlResponse : PddResponseModel
{

    /// <summary>
    /// 推广链接返回对象
    /// </summary>
    [JsonPropertyName("rp_promotion_url_generate_response")]
    public RpPromotionUrlGenerateResponseResponse RpPromotionUrlGenerateResponse { get; set; }
    public partial class RpPromotionUrlGenerateResponseResponse : PddResponseModel
    {

        /// <summary>
        /// resource_list
        /// </summary>
        [JsonPropertyName("resource_list")]
        public List<ResourceListResponse> ResourceList { get; set; }

        /// <summary>
        /// url_list
        /// </summary>
        [JsonPropertyName("url_list")]
        public List<UrlListResponse> UrlList { get; set; }
        public partial class ResourceListResponse : PddResponseModel
        {

            /// <summary>
            /// 活动描述
            /// </summary>
            [JsonPropertyName("desc")]
            public string Desc { get; set; }

            /// <summary>
            /// 活动地址
            /// </summary>
            [JsonPropertyName("url")]
            public string Url { get; set; }

        }
        public partial class UrlListResponse : PddResponseModel
        {

            /// <summary>
            /// 推广移动短链接，对应出参mobile_url的短链接，与mobile_url功能一致。
            /// </summary>
            [JsonPropertyName("mobile_short_url")]
            public string MobileShortUrl { get; set; }

            /// <summary>
            /// 推广移动链接，用户安装拼多多APP的情况下会唤起APP，否则唤起H5页面
            /// </summary>
            [JsonPropertyName("mobile_url")]
            public string MobileUrl { get; set; }

            /// <summary>
            /// 推广多人团移动短链接
            /// </summary>
            [JsonPropertyName("multi_group_mobile_short_url")]
            public string MultiGroupMobileShortUrl { get; set; }

            /// <summary>
            /// 推广多人团移动链接，用户安装拼多多APP的情况下会唤起APP，否则唤起H5页面
            /// </summary>
            [JsonPropertyName("multi_group_mobile_url")]
            public string MultiGroupMobileUrl { get; set; }

            /// <summary>
            /// 推广多人团短链接
            /// </summary>
            [JsonPropertyName("multi_group_short_url")]
            public string MultiGroupShortUrl { get; set; }

            /// <summary>
            /// 推广多人团链接，唤起H5页面
            /// </summary>
            [JsonPropertyName("multi_group_url")]
            public string MultiGroupUrl { get; set; }

            /// <summary>
            /// qq小程序信息
            /// </summary>
            [JsonPropertyName("qq_app_info")]
            public QqAppInfoResponse QqAppInfo { get; set; }

            /// <summary>
            /// schema链接，用户安装拼多多APP的情况下会唤起APP（需客户端支持schema跳转协议）
            /// </summary>
            [JsonPropertyName("schema_url")]
            public string SchemaUrl { get; set; }

            /// <summary>
            /// 推广短链接，对应出参url的短链接，与url功能一致。
            /// </summary>
            [JsonPropertyName("short_url")]
            public string ShortUrl { get; set; }

            /// <summary>
            /// 推广长链接，唤起H5页面
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
                /// 小程序icon
                /// </summary>
                [JsonPropertyName("we_app_icon_url")]
                public string WeAppIconUrl { get; set; }

            }

        }

    }

}

