namespace PddOpenSdk.Models.PddApiResult
{
    
public class SkuStockUpdateResponse
{
    public bool is_success { get; set; }
}


public class UpdateGoodsSkuStockApiResult
{
    public SkuStockUpdateResponse sku_stock_update_response { get; set; }
}

}
