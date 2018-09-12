using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class AdUnitCreateResponse
{
    public bool is_success { get; set; }
}


public class CreateAdUnitApiResult
{
    public AdUnitCreateResponse ad_unit_create_response { get; set; }
}

}
