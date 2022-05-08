using PddOpenSdk.Common;
using PddOpenSdk.Models.Request.Goods;
using Xunit;

namespace Sdk.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }


    [Fact]
    public void Shoud_ToDictionary()
    {
        var request = new GetGoodsList() {
            OuterId = "1",
            OuterGoodsId = "2",
            GoodsName = "GoodsName",
            Page = 1,
            PageSize = 10,

        };
        var dict = Function.ToDictionary(request);

        Assert.Equal("1", dict["outer_id"]);
        Assert.Equal(1, dict["page"]);
        Assert.Equal("GoodsName", dict["goods_name"]);
    }
}
