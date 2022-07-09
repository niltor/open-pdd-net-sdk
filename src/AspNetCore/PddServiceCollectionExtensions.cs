using Microsoft.Extensions.DependencyInjection;

namespace PddOpenSdk.AspNetCore;
public static class PddServiceExtensions
{

    /// <summary>
    /// 添加批多多服务
    /// </summary>
    /// <param name="services"></param>
    /// <param name="optionsAction"></param>
    public static void AddPdd(this IServiceCollection services, Action<PddOptions> optionsAction = null)
    {
        if (optionsAction != null)
        {
            services.Configure(optionsAction);
        }
        services.AddSingleton(typeof(PddService));
    }
}

