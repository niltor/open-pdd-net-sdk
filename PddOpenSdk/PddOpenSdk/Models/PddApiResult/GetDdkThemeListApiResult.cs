namespace PddOpenSdk.Models.PddApiResult
{
    
public class ThemeList
{
    public int id { get; set; }
    public string image_url { get; set; }
    public string name { get; set; }
    public int goods_num { get; set; }
}


public class ThemeListGetResponse
{
    public int total { get; set; }
    public List<ThemeList> theme_list { get; set; }
}


public class GetDdkThemeListApiResult
{
    public ThemeListGetResponse theme_list_get_response { get; set; }
}

}
