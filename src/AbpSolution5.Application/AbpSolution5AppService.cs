using AbpSolution5.Localization;
using Volo.Abp.Application.Services;

namespace AbpSolution5;

/* Inherit your application services from this class.
 */
public abstract class AbpSolution5AppService : ApplicationService
{
    protected AbpSolution5AppService()
    {
        LocalizationResource = typeof(AbpSolution5Resource);
    }
}
