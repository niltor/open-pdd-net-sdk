namespace PddOpenSdk.Models.Response.Fds;
public partial class SlaveFdsWaybillReturnResponse : PddResponseModel
{

    /// <summary>
    /// response
    /// </summary>
    [JsonPropertyName("pdd_fds_waybill_return_slave_response")]
    public PddFdsWaybillReturnSlaveResponseResponse PddFdsWaybillReturnSlaveResponse { get; set; }
    public partial class PddFdsWaybillReturnSlaveResponseResponse : PddResponseModel
    {

        /// <summary>
        /// 回传结果true：成功  false：失败
        /// </summary>
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

    }

}

