namespace App.Models.PddApiResult
{
    
public class LogisticsCompany
{
    public string id { get; set; }
    public string logistics_company { get; set; }
}


public class LogisticsCompaniesGetResponse
{
    public List<LogisticsCompany> logistics_companies { get; set; }
}


public class GetLogisticsCompaniesApiResult
{
    public LogisticsCompaniesGetResponse logistics_companies_get_response { get; set; }
}

}
