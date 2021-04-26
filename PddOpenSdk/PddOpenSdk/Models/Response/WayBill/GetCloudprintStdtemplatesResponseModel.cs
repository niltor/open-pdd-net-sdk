using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.WayBill
{
    public partial class GetCloudprintStdtemplatesResponseModel : PddResponseModel
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("pdd_cloudprint_stdtemplates_get_response")]
        public PddCloudprintStdtemplatesGetResponseResponseModel PddCloudprintStdtemplatesGetResponse { get; set; }
        public partial class PddCloudprintStdtemplatesGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 结果集
            /// </summary>
            [JsonProperty("result")]
            public ResultResponseModel Result { get; set; }
            public partial class ResultResponseModel : PddResponseModel
            {
                /// <summary>
                /// 所有wp的标准模板
                /// </summary>
                [JsonProperty("datas")]
                public List<DatasResponseModel> Datas { get; set; }
                public partial class DatasResponseModel : PddResponseModel
                {
                    /// <summary>
                    /// 该wp的所有标准模板
                    /// </summary>
                    [JsonProperty("standard_templates")]
                    public List<StandardTemplatesResponseModel> StandardTemplates { get; set; }
                    /// <summary>
                    /// wp编码
                    /// </summary>
                    [JsonProperty("wp_code")]
                    public string WpCode { get; set; }
                    public partial class StandardTemplatesResponseModel : PddResponseModel
                    {
                        /// <summary>
                        /// 模板id
                        /// </summary>
                        [JsonProperty("standard_template_id")]
                        public long? StandardTemplateId { get; set; }
                        /// <summary>
                        /// 模板名称
                        /// </summary>
                        [JsonProperty("standard_template_name")]
                        public string StandardTemplateName { get; set; }
                        /// <summary>
                        /// 模板url
                        /// </summary>
                        [JsonProperty("standard_template_url")]
                        public string StandardTemplateUrl { get; set; }
                        /// <summary>
                        /// 模版类型
                        /// </summary>
                        [JsonProperty("standard_waybill_type")]
                        public int? StandardWaybillType { get; set; }

                    }

                }

            }

        }

    }

}
