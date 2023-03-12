using Microsoft.Extensions.DependencyInjection;

namespace PddOpenSdk.AspNetCore;
public static class PddServiceExtensions
{

    /// <summary>
    /// 添加拼多多服务
    /// </summary>
    public static void AddPdd(this IServiceCollection services, Action<PddOptions> optionsAction = null)
    {
        if (optionsAction != null)
        {
            services.Configure(optionsAction);
        }
        services.AddSingleton(typeof(PddService));
    }
}

