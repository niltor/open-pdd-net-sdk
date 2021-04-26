using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Ddk
{
    public partial class GenerateDdkRpPromUrlResponseModel : PddResponseModel
    {
        /// <summary>
        /// 推广链接返回对象
        /// </summary>
        [JsonProperty("rp_promotion_url_generate_response")]
        public RpPromotionUrlGenerateResponseResponseModel RpPromotionUrlGenerateResponse { get; set; }
        public partial class RpPromotionUrlGenerateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// resource_list
            /// </summary>
            [JsonProperty("resource_list")]
            public List<ResourceListResponseModel> ResourceList { get; set; }
            /// <summary>
            /// url_list
            /// </summary>
            [JsonProperty("url_list")]
            public List<UrlListResponseModel> UrlList { get; set; }
            public partial class ResourceListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 活动描述
                /// </summary>
                [JsonProperty("desc")]
                public string Desc { get; set; }
                /// <summary>
                /// 活动地址
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }

            }
            public partial class UrlListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 推广移动短链接，对应出参mobile_url的短链接，与mobile_url功能一致。
                /// </summary>
                [JsonProperty("mobile_short_url")]
                public string MobileShortUrl { get; set; }
                /// <summary>
                /// 推广移动链接，用户安装拼多多APP的情况下会唤起APP，否则唤起H5页面
                /// </summary>
                [JsonProperty("mobile_url")]
                public string MobileUrl { get; set; }
                /// <summary>
                /// 推广多人团移动短链接
                /// </summary>
                [JsonProperty("multi_group_mobile_short_url")]
                public string MultiGroupMobileShortUrl { get; set; }
                /// <summary>
                /// 推广多人团移动链接，用户安装拼多多APP的情况下会唤起APP，否则唤起H5页面
                /// </summary>
                [JsonProperty("multi_group_mobile_url")]
                public string MultiGroupMobileUrl { get; set; }
                /// <summary>
                /// 推广多人团短链接
                /// </summary>
                [JsonProperty("multi_group_short_url")]
                public string MultiGroupShortUrl { get; set; }
                /// <summary>
                /// 推广多人团链接，唤起H5页面
                /// </summary>
                [JsonProperty("multi_group_url")]
                public string MultiGroupUrl { get; set; }
                /// <summary>
                /// qq小程序信息
                /// </summary>
                [JsonProperty("qq_app_info")]
                public QqAppInfoResponseModel QqAppInfo { get; set; }
                /// <summary>
                /// schema链接，用户安装拼多多APP的情况下会唤起APP（需客户端支持schema跳转协议）
                /// </summary>
                [JsonProperty("schema_url")]
                public string SchemaUrl { get; set; }
                /// <summary>
                /// 推广短链接，对应出参url的短链接，与url功能一致
                /// </summary>
                [JsonProperty("short_url")]
                public string ShortUrl { get; set; }
                /// <summary>
                /// 普通推广长链接，唤起H5页面
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; }
                /// <summary>
                /// 拼多多福利券微信小程序信息
                /// </summary>
                [JsonProperty("we_app_info")]
                public WeAppInfoResponseModel WeAppInfo { get; set; }
                public partial class QqAppInfoResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 拼多多小程序id
                    /// </summary>
                    [JsonProperty("app_id")]
                    public string AppId { get; set; }
                    /// <summary>
                    /// Banner图
                    /// </summary>
                    [JsonProperty("banner_url")]
                    public string BannerUrl { get; set; }
                    /// <summary>
                    /// 描述
                    /// </summary>
                    [JsonProperty("desc")]
                    public string Desc { get; set; }
                    /// <summary>
                    /// 小程序path值
                    /// </summary>
                    [JsonProperty("page_path")]
                    public string PagePath { get; set; }
                    /// <summary>
                    /// 小程序icon
                    /// </summary>
                    [JsonProperty("qq_app_icon_url")]
                    public string QqAppIconUrl { get; set; }
                    /// <summary>
                    /// 来源名
                    /// </summary>
                    [JsonProperty("source_display_name")]
                    public string SourceDisplayName { get; set; }
                    /// <summary>
                    /// 小程序标题
                    /// </summary>
                    [JsonProperty("title")]
                    public string Title { get; set; }
                    /// <summary>
                    /// 用户名
                    /// </summary>
                    [JsonProperty("user_name")]
                    public string UserName { get; set; }

                }
                public partial class WeAppInfoResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 小程序id
                    /// </summary>
                    [JsonProperty("app_id")]
                    public string AppId { get; set; }
                    /// <summary>
                    /// Banner图
                    /// </summary>
                    [JsonProperty("banner_url")]
                    public string BannerUrl { get; set; }
                    /// <summary>
                    /// 描述
                    /// </summary>
                    [JsonProperty("desc")]
                    public string Desc { get; set; }
                    /// <summary>
                    /// 小程序path值
                    /// </summary>
                    [JsonProperty("page_path")]
                    public string PagePath { get; set; }
                    /// <summary>
                    /// 来源名
                    /// </summary>
                    [JsonProperty("source_display_name")]
                    public string SourceDisplayName { get; set; }
                    /// <summary>
                    /// 小程序标题
                    /// </summary>
                    [JsonProperty("title")]
                    public string Title { get; set; }
                    /// <summary>
                    /// 用户名
                    /// </summary>
                    [JsonProperty("user_name")]
                    public string UserName { get; set; }
                    /// <summary>
                    /// 小程序icon
                    /// </summary>
                    [JsonProperty("we_app_icon_url")]
                    public string WeAppIconUrl { get; set; }

                }

            }

        }

    }

}
