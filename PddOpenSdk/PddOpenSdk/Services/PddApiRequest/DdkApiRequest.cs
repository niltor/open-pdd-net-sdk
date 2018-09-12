using PddOpenSdk.Models.PddApiResult;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApiRequest
{
    public class DdkApiRequest : PddRequest {
        /// <summary>
/// 获取多多客拉新账单
/// </summary>
/// <param name="Type">该值为：pdd.ddk.oauth.app.new.bill.list.get</param>
/// <param name="StartTime">最后更新时间--查询时间开始。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数</param>
/// <param name="EndTime">最后更新时间--查询时间开始。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数</param>
/// <param name="Pid">60000_2000</param>
/// <param name="PageSize">返回的每页结果列表数，默认为100，范围为10到100，建议使用40~50，可以提高成功率，减少超时数量。</param>
/// <param name="Page">第几页，从1到10000，默认1，注：使用最后更新时间范围增量同步时，必须采用倒序的分页方式（从最后一页往回取）才能避免漏的问题</param>
public async Task<GetDdkOauthAppNewBillListApiResult> GetDdkOauthAppNewBillListAsync(string Type,int StartTime,int EndTime,string Pid,int PageSize,int Page)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("start_time",StartTime);
dic.Add("end_time",EndTime);
dic.Add("pid",Pid);
dic.Add("page_size",PageSize);
dic.Add("page",Page);
    
    var result = Post<GetDdkOauthAppNewBillListApiResult>("pdd.ddk.oauth.app.new.bill.list.get",dic);
    return JsonConvert.DeserializeObject<GetDdkOauthAppNewBillListApiResult>(result);
}/// <summary>
/// 生成商城推广链接接口
/// </summary>
/// <param name="PIdList">推广位列表，例如：["60005_612"]</param>
/// <param name="ChannelType">0, "9.9包邮", 1, "今日爆款", 2, "品牌清仓", 3, "默认商城", 非必填 ,默认是3</param>
/// <param name="GenerateShortUrl">是否生成短链接。true-是，false-否，默认false</param>
/// <param name="GenerateMobile">是否生成手机跳转链接。true-是，false-否，默认false</param>
/// <param name="MultiGroup">单人团多人团标志。true-多人团，false-单人团 默认false</param>
/// <param name="CustomParameters">自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。</param>
/// <param name="GenerateWeappWebview">是否唤起微信客户端， 默认false 否，true 是</param>
/// <param name="WeAppWebViewShortUrl">唤起微信app推广短链接</param>
/// <param name="WeAppWebWiewUrl">唤起微信app推广链接</param>
public async Task<GenerateDdkOauthCmsPromUrlApiResult> GenerateDdkOauthCmsPromUrlAsync(string PIdList,int ChannelType,boolean GenerateShortUrl,boolean GenerateMobile,boolean MultiGroup,string CustomParameters,boolean GenerateWeappWebview,boolean WeAppWebViewShortUrl,boolean WeAppWebWiewUrl)
{
    var dic = new Dictionary<string, string>();
    dic.Add("p_id_list",PIdList);
dic.Add("channel_type",ChannelType);
dic.Add("generate_short_url",GenerateShortUrl);
dic.Add("generate_mobile",GenerateMobile);
dic.Add("multi_group",MultiGroup);
dic.Add("custom_parameters",CustomParameters);
dic.Add("generate_weapp_webview",GenerateWeappWebview);
dic.Add("we_app_web_view_short_url",WeAppWebViewShortUrl);
dic.Add("we_app_web_wiew_url",WeAppWebWiewUrl);
    
    var result = Post<GenerateDdkOauthCmsPromUrlApiResult>("pdd.ddk.oauth.cms.prom.url.generate",dic);
    return JsonConvert.DeserializeObject<GenerateDdkOauthCmsPromUrlApiResult>(result);
}/// <summary>
/// 多多进宝推广位创建接口
/// </summary>
/// <param name="Type">该值为：pdd.ddk.oauth.goods.pid.generate</param>
/// <param name="Number">要生成的推广位数量，默认为10，范围为：1~100</param>
/// <param name="PIdNameList">推广位名称，例如["1","2"]</param>
public async Task<GenerateDdkOauthGoodsPidApiResult> GenerateDdkOauthGoodsPidAsync(string Type,int Number,string PIdNameList)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("number",Number);
dic.Add("p_id_name_list",PIdNameList);
    
    var result = Post<GenerateDdkOauthGoodsPidApiResult>("pdd.ddk.oauth.goods.pid.generate",dic);
    return JsonConvert.DeserializeObject<GenerateDdkOauthGoodsPidApiResult>(result);
}/// <summary>
/// 多多客已生成推广位信息查询
/// </summary>
/// <param name="Type">该值为：pdd.ddk.oauth.goods.pid.query</param>
/// <param name="Page">返回的页数</param>
/// <param name="PageSize">返回的每页推广位数量</param>
public async Task<QueryDdkOauthGoodsPidApiResult> QueryDdkOauthGoodsPidAsync(string Type,int Page,int PageSize)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("page",Page);
dic.Add("page_size",PageSize);
    
    var result = Post<QueryDdkOauthGoodsPidApiResult>("pdd.ddk.oauth.goods.pid.query",dic);
    return JsonConvert.DeserializeObject<QueryDdkOauthGoodsPidApiResult>(result);
}/// <summary>
/// 生成多多进宝推广链接
/// </summary>
/// <param name="Type">该值为：pdd.ddk.oauth.goods.prom.url.generate</param>
/// <param name="PId">推广位ID</param>
/// <param name="GoodsIdList">商品ID，仅支持单个查询</param>
/// <param name="GenerateShortUrl">是否生成短链接，true-是，false-否</param>
/// <param name="MultiGroup">true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手</param>
/// <param name="CustomParameters">自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。</param>
/// <param name="PullNew">是否开启订单拉新，true表示开启（订单拉新奖励特权仅支持白名单，请联系工作人员开通）</param>
/// <param name="GenerateWeappWebview">是否生成唤起微信客户端链接，true-是，false-否，默认false</param>
/// <param name="ZsDuoId">招商多多客ID</param>
public async Task<GenerateDdkOauthGoodsPromUrlApiResult> GenerateDdkOauthGoodsPromUrlAsync(string Type,string PId,string GoodsIdList,boolean GenerateShortUrl,boolean MultiGroup,string CustomParameters,boolean PullNew,boolean GenerateWeappWebview,int ZsDuoId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("p_id",PId);
dic.Add("goods_id_list",GoodsIdList);
dic.Add("generate_short_url",GenerateShortUrl);
dic.Add("multi_group",MultiGroup);
dic.Add("custom_parameters",CustomParameters);
dic.Add("pull_new",PullNew);
dic.Add("generate_weapp_webview",GenerateWeappWebview);
dic.Add("zs_duo_id",ZsDuoId);
    
    var result = Post<GenerateDdkOauthGoodsPromUrlApiResult>("pdd.ddk.oauth.goods.prom.url.generate",dic);
    return JsonConvert.DeserializeObject<GenerateDdkOauthGoodsPromUrlApiResult>(result);
}/// <summary>
/// 生成招商推广链接
/// </summary>
/// <param name="SourceUrl">需转链的链接</param>
/// <param name="Pid">渠道id</param>
public async Task<GenDdkOauthGoodsZsUnitUrlApiResult> GenDdkOauthGoodsZsUnitUrlAsync(string SourceUrl,string Pid)
{
    var dic = new Dictionary<string, string>();
    dic.Add("source_url",SourceUrl);
dic.Add("pid",Pid);
    
    var result = Post<GenDdkOauthGoodsZsUnitUrlApiResult>("pdd.ddk.oauth.goods.zs.unit.url.gen",dic);
    return JsonConvert.DeserializeObject<GenDdkOauthGoodsZsUnitUrlApiResult>(result);
}/// <summary>
/// 多多客工具查询转盘拉新订单列表
/// </summary>
/// <param name="Pid">推广位ID</param>
/// <param name="StartTime">最后更新时间--查询时间开始。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数</param>
/// <param name="EndTime">最后更新时间--查询时间结束。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数</param>
/// <param name="PageSize">返回的每页结果列表数，默认为100，范围为10到100，建议使用40~50，可以提高成功率，减少超时数量。</param>
/// <param name="Page">第几页，从1到10000，默认1，注：使用最后更新时间范围增量同步时，必须采用倒序的分页方式（从最后一页往回取）才能避免漏的问题</param>
/// <param name="CustomerParamters">自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。</param>
public async Task<GetDdkOauthLotteryNewListApiResult> GetDdkOauthLotteryNewListAsync(strng Pid,int StartTime,int EndTime,numner PageSize,int Page,string CustomerParamters)
{
    var dic = new Dictionary<string, string>();
    dic.Add("pid",Pid);
dic.Add("start_time",StartTime);
dic.Add("end_time",EndTime);
dic.Add("page_size",PageSize);
dic.Add("page",Page);
dic.Add("customer_paramters",CustomerParamters);
    
    var result = Post<GetDdkOauthLotteryNewListApiResult>("pdd.ddk.oauth.lottery.new.list.get",dic);
    return JsonConvert.DeserializeObject<GetDdkOauthLotteryNewListApiResult>(result);
}/// <summary>
/// 多多客工具生成转盘抽免单url
/// </summary>
/// <param name="PidList">推广位</param>
/// <param name="GenerateWeappWebview">是否生成唤起微信客户端链接，true-是，false-否，默认false</param>
/// <param name="GenerateShortUrl">是否生成短链接，true-是，false-否</param>
/// <param name="MultiGroup">true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手</param>
/// <param name="CustomerParamters">自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。</param>
public async Task<GenDdkOauthLotteryUrlApiResult> GenDdkOauthLotteryUrlAsync(string PidList,boolean GenerateWeappWebview,boolean GenerateShortUrl,boolean MultiGroup,string CustomerParamters)
{
    var dic = new Dictionary<string, string>();
    dic.Add("pid_list",PidList);
dic.Add("generate_weapp_webview",GenerateWeappWebview);
dic.Add("generate_short_url",GenerateShortUrl);
dic.Add("multi_group",MultiGroup);
dic.Add("customer_paramters",CustomerParamters);
    
    var result = Post<GenDdkOauthLotteryUrlApiResult>("pdd.ddk.oauth.lottery.url.gen",dic);
    return JsonConvert.DeserializeObject<GenDdkOauthLotteryUrlApiResult>(result);
}/// <summary>
/// 多多客工具生成店铺优惠券推广链接API
/// </summary>
/// <param name="MallId">店铺id</param>
/// <param name="Pid">推广位</param>
/// <param name="CouponIds">优惠券id</param>
/// <param name="GenerateWeappWebview">是否生成唤起微信客户端链接，true-是，false-否，默认false</param>
/// <param name="GenerateShortUrl">是否生成短链接，true-是，false-否</param>
/// <param name="MultiGroup">true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手</param>
public async Task<GenDdkOauthMallCouponUrlApiResult> GenDdkOauthMallCouponUrlAsync(int MallId,string Pid,string CouponIds,boolean GenerateWeappWebview,boolean GenerateShortUrl,boolean MultiGroup)
{
    var dic = new Dictionary<string, string>();
    dic.Add("mall_id",MallId);
dic.Add("pid",Pid);
dic.Add("coupon_ids",CouponIds);
dic.Add("generate_weapp_webview",GenerateWeappWebview);
dic.Add("generate_short_url",GenerateShortUrl);
dic.Add("multi_group",MultiGroup);
    
    var result = Post<GenDdkOauthMallCouponUrlApiResult>("pdd.ddk.oauth.mall.coupon.url.gen",dic);
    return JsonConvert.DeserializeObject<GenDdkOauthMallCouponUrlApiResult>(result);
}/// <summary>
/// 多多客工具生成店铺推广链接API
/// </summary>
/// <param name="MallId">店铺id</param>
/// <param name="Pid">推广位</param>
/// <param name="GenerateWeappWebview">是否生成唤起微信客户端链接，true-是，false-否，默认false</param>
/// <param name="GenerateShortUrl">是否生成短链接，true-是，false-否</param>
/// <param name="MultiGroup">true--生成多人团推广链接 false--生成单人团推广链接（默认false）1、单人团推广链接：用户访问单人团推广链接，可直接购买商品无需拼团。2、多人团推广链接：用户访问双人团推广链接开团，若用户分享给他人参团，则开团者和参团者的佣金均结算给推手</param>
public async Task<GenDdkOauthMallUrlApiResult> GenDdkOauthMallUrlAsync(int MallId,string Pid,boolean GenerateWeappWebview,boolean GenerateShortUrl,boolean MultiGroup)
{
    var dic = new Dictionary<string, string>();
    dic.Add("mall_id",MallId);
dic.Add("pid",Pid);
dic.Add("generate_weapp_webview",GenerateWeappWebview);
dic.Add("generate_short_url",GenerateShortUrl);
dic.Add("multi_group",MultiGroup);
    
    var result = Post<GenDdkOauthMallUrlApiResult>("pdd.ddk.oauth.mall.url.gen",dic);
    return JsonConvert.DeserializeObject<GenDdkOauthMallUrlApiResult>(result);
}/// <summary>
/// 获取订单详情
/// </summary>
/// <param name="OrderSn">订单号</param>
public async Task<GetDdkOauthOrderDetailApiResult> GetDdkOauthOrderDetailAsync(string OrderSn)
{
    var dic = new Dictionary<string, string>();
    dic.Add("order_sn",OrderSn);
    
    var result = Post<GetDdkOauthOrderDetailApiResult>("pdd.ddk.oauth.order.detail.get",dic);
    return JsonConvert.DeserializeObject<GetDdkOauthOrderDetailApiResult>(result);
}/// <summary>
/// 按照更新时间段增量同步推广订单信息
/// </summary>
/// <param name="Type">该值为:pdd.ddk.oauth.order.list.increment.get</param>
/// <param name="StartUpdateTime">最近90天内多多进宝商品订单更新时间--查询时间开始。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数</param>
/// <param name="EndUpdateTime">最近90天内多多进宝商品订单更新时间--查询时间结束。note：此时间为时间戳，指格林威治时间 1970 年01 月 01 日 00 时 00 分 00 秒(北京时间 1970 年 01 月 01 日 08 时 00 分 00 秒)起至现在的总秒数</param>
/// <param name="PId">推广位ID</param>
/// <param name="PageSize">返回的每页结果订单数，默认为100，范围为10到100，建议使用40~50，可以提高成功率，减少超时数量。</param>
/// <param name="Page">第几页，从1到10000，默认1，注：使用最后更新时间范围增量同步时，必须采用倒序的分页方式（从最后一页往回取）才能避免漏单问题。</param>
public async Task<GetDdkOauthOrderListIncrementApiResult> GetDdkOauthOrderListIncrementAsync(string Type,int StartUpdateTime,string EndUpdateTime,string PId,int PageSize,int Page)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("start_update_time",StartUpdateTime);
dic.Add("end_update_time",EndUpdateTime);
dic.Add("p_id",PId);
dic.Add("page_size",PageSize);
dic.Add("page",Page);
    
    var result = Post<GetDdkOauthOrderListIncrementApiResult>("pdd.ddk.oauth.order.list.increment.get",dic);
    return JsonConvert.DeserializeObject<GetDdkOauthOrderListIncrementApiResult>(result);
}/// <summary>
/// 生成红包推广链接接口
/// </summary>
/// <param name="PIdList">推广位列表，例如：["60005_612"]</param>
/// <param name="GenerateWeappWebview">是否唤起微信客户端， 默认false 否，true 是</param>
/// <param name="GenerateShortUrl">是否生成短链接。true-是，false-否，默认false</param>
/// <param name="CustomParameters">自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。</param>
/// <param name="WeAppWebViewShortUrl">唤起微信app推广短链接</param>
/// <param name="WeAppWebWiewUrl">唤起微信app推广链接</param>
public async Task<GenerateDdkOauthRpPromUrlApiResult> GenerateDdkOauthRpPromUrlAsync(string PIdList,boolean GenerateWeappWebview,boolean GenerateShortUrl,string CustomParameters,boolean WeAppWebViewShortUrl,boolean WeAppWebWiewUrl)
{
    var dic = new Dictionary<string, string>();
    dic.Add("p_id_list",PIdList);
dic.Add("generate_weapp_webview",GenerateWeappWebview);
dic.Add("generate_short_url",GenerateShortUrl);
dic.Add("custom_parameters",CustomParameters);
dic.Add("we_app_web_view_short_url",WeAppWebViewShortUrl);
dic.Add("we_app_web_wiew_url",WeAppWebWiewUrl);
    
    var result = Post<GenerateDdkOauthRpPromUrlApiResult>("pdd.ddk.oauth.rp.prom.url.generate",dic);
    return JsonConvert.DeserializeObject<GenerateDdkOauthRpPromUrlApiResult>(result);
}/// <summary>
/// 多多进宝主题推广链接生成接口
/// </summary>
/// <param name="Type">该值为:pdd.ddk.oauth.theme.prom.url.generate</param>
/// <param name="Pid">推广位ID</param>
/// <param name="ThemeIdList">主题ID列表,例如[1,235]</param>
/// <param name="GenerateShortUrl">是否生成短链接,true-是,false-否</param>
/// <param name="GenerateMobile">是否生成手机跳转链接。true-是,false-否,默认false</param>
/// <param name="CustomParameters">自定义参数,为链接打上自定义标签。自定义参数最长限制64个字节。</param>
/// <param name="GenerateWeappWebview">是否唤起微信客户端， 默认false 否，true 是</param>
/// <param name="WeAppWebViewShortUrl">唤起微信app推广短链接</param>
/// <param name="WeAppWebWiewUrl">唤起微信app推广链接</param>
public async Task<GenerateDdkOauthThemePromUrlApiResult> GenerateDdkOauthThemePromUrlAsync(string Type,string Pid,string ThemeIdList,boolean GenerateShortUrl,boolean GenerateMobile,string CustomParameters,boolean GenerateWeappWebview,boolean WeAppWebViewShortUrl,boolean WeAppWebWiewUrl)
{
    var dic = new Dictionary<string, string>();
    dic.Add("type",Type);
dic.Add("pid",Pid);
dic.Add("theme_id_list",ThemeIdList);
dic.Add("generate_short_url",GenerateShortUrl);
dic.Add("generate_mobile",GenerateMobile);
dic.Add("custom_parameters",CustomParameters);
dic.Add("generate_weapp_webview",GenerateWeappWebview);
dic.Add("we_app_web_view_short_url",WeAppWebViewShortUrl);
dic.Add("we_app_web_wiew_url",WeAppWebWiewUrl);
    
    var result = Post<GenerateDdkOauthThemePromUrlApiResult>("pdd.ddk.oauth.theme.prom.url.generate",dic);
    return JsonConvert.DeserializeObject<GenerateDdkOauthThemePromUrlApiResult>(result);
}/// <summary>
/// 多多客工具生成单品推广小程序二维码
/// </summary>
/// <param name="PId">推广位ID</param>
/// <param name="GoodsIdList">商品ID，仅支持单个查询</param>
/// <param name="CustomParameters">自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。</param>
/// <param name="ZsDuoId">招商多多客ID</param>
public async Task<GenDdkOauthWeappQrcodeUrlApiResult> GenDdkOauthWeappQrcodeUrlAsync(string PId,string GoodsIdList,string CustomParameters,int ZsDuoId)
{
    var dic = new Dictionary<string, string>();
    dic.Add("p_id",PId);
dic.Add("goods_id_list",GoodsIdList);
dic.Add("custom_parameters",CustomParameters);
dic.Add("zs_duo_id",ZsDuoId);
    
    var result = Post<GenDdkOauthWeappQrcodeUrlApiResult>("pdd.ddk.oauth.weapp.qrcode.url.gen",dic);
    return JsonConvert.DeserializeObject<GenDdkOauthWeappQrcodeUrlApiResult>(result);
}/// <summary>
/// 查询招商推广计划商品接口
/// </summary>
/// <param name="ZsDuoId">招商多多客id</param>
/// <param name="PageSize">每页个数，默认100</param>
/// <param name="Page">页码，默认为1</param>
public async Task<QueryDdkOauthZsUnitGoodsApiResult> QueryDdkOauthZsUnitGoodsAsync(int ZsDuoId,int PageSize,int Page)
{
    var dic = new Dictionary<string, string>();
    dic.Add("zs_duo_id",ZsDuoId);
dic.Add("page_size",PageSize);
dic.Add("page",Page);
    
    var result = Post<QueryDdkOauthZsUnitGoodsApiResult>("pdd.ddk.oauth.zs.unit.goods.query",dic);
    return JsonConvert.DeserializeObject<QueryDdkOauthZsUnitGoodsApiResult>(result);
}
    }
}
