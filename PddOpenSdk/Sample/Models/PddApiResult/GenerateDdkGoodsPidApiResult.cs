using System.Collections.Generic;
namespace PddOpenSdk.Models.PddApiResult
{
    
public class PIdList
{
    public string p_id { get; set; }
    public object p_id_name { get; set; }
}


public class PIdGenerateResponse
{
    public List<PIdList> p_id_list { get; set; }
}


public class GenerateDdkGoodsPidApiResult
{
    public PIdGenerateResponse p_id_generate_response { get; set; }
}

}
