using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Response.Mall
{
    public partial class GetMallInfoBondedWarehouseResponseModel : PddResponseModel
    {
        /// <summary>
        /// reponse
        /// </summary>
        [JsonProperty("mall_info_bonded_warehouse_get_response")]
        public MallInfoBondedWarehouseGetResponseResponseModel MallInfoBondedWarehouseGetResponse { get; set; }
        public partial class MallInfoBondedWarehouseGetResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// list
            /// </summary>
            [JsonProperty("info_list")]
            public List<InfoListResponseModel> InfoList { get; set; }
            public partial class InfoListResponseModel : PddResponseModel
            {
                /// <summary>
                /// 保税仓标识
                /// </summary>
                [JsonProperty("bonded_warehouse_key")]
                public string BondedWarehouseKey { get; set; }
                /// <summary>
                /// 保税仓名字
                /// </summary>
                [JsonProperty("bonded_warehouse_name")]
                public string BondedWarehouseName { get; set; }
                /// <summary>
                /// 清关服务商
                /// </summary>
                [JsonProperty("customs_clearance_service_provider_list")]
                public List<string> CustomsClearanceServiceProviderList { get; set; }
                /// <summary>
                /// 报关海关
                /// </summary>
                [JsonProperty("customs_declaration_location")]
                public string CustomsDeclarationLocation { get; set; }

            }

        }

    }

}
