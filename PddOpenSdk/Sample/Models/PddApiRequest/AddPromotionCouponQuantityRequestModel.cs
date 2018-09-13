using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiRequest
{
    public partial class AddPromotionCouponQuantityRequestModel : PddRequestModel
    {
        /// <summary>
/// 券批次ID
/// </summary>
[JsonProperty("batch_id")]
public int BatchId {get;set;}
/// <summary>
/// 要增加的数量
/// </summary>
[JsonProperty("add_quantity")]
public int AddQuantity {get;set;}
}
}

