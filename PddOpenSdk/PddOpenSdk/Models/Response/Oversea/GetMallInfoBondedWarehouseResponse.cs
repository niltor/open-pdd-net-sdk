namespace PddOpenSdk.Models.Response.Oversea;
public partial class GetMallInfoBondedWarehouseResponse : PddResponseModel
{

    /// <summary>
    /// reponse
    /// </summary>
    [JsonPropertyName("mall_info_bonded_warehouse_get_response")]
    public MallInfoBondedWarehouseGetResponseResponse MallInfoBondedWarehouseGetResponse { get; set; }
    public partial class MallInfoBondedWarehouseGetResponseResponse : PddResponseModel
    {

        /// <summary>
        /// list
        /// </summary>
        [JsonPropertyName("info_list")]
        public List<InfoListResponse> InfoList { get; set; }
        public partial class InfoListResponse : PddResponseModel
        {

            /// <summary>
            /// 保税仓标识
            /// </summary>
            [JsonPropertyName("bonded_warehouse_key")]
            public string BondedWarehouseKey { get; set; }

            /// <summary>
            /// 保税仓名字
            /// </summary>
            [JsonPropertyName("bonded_warehouse_name")]
            public string BondedWarehouseName { get; set; }

            /// <summary>
            /// 清关服务商
            /// </summary>
            [JsonPropertyName("customs_clearance_service_provider_list")]
            public List<string> CustomsClearanceServiceProviderList { get; set; }

            /// <summary>
            /// 报关海关
            /// </summary>
            [JsonPropertyName("customs_declaration_location")]
            public string CustomsDeclarationLocation { get; set; }

        }

    }

}

