using AbpSolution5.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpSolution5.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpSolution5Controller : AbpControllerBase
{
    protected AbpSolution5Controller()
    {
        LocalizationResource = typeof(AbpSolution5Resource);
    }
}
