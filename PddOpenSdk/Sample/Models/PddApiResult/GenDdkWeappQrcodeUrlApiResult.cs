using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class WeappQrcodeGenerateResponse
{
    public string url { get; set; }
}


public class GenDdkWeappQrcodeUrlApiResult
{
    public WeappQrcodeGenerateResponse weapp_qrcode_generate_response { get; set; }
}

}
