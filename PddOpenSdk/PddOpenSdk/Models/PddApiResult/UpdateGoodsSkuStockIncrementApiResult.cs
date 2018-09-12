namespace PddOpenSdk.Models.PddApiResult
{
    
public class SkuStockIncrementUpdateResponse
{
    public bool is_success { get; set; }
}


public class UpdateGoodsSkuStockIncrementApiResult
{
    public SkuStockIncrementUpdateResponse sku_stock_increment_update_response { get; set; }
}

}
