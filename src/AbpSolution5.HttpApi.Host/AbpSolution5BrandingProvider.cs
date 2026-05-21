using Microsoft.Extensions.Localization;
using AbpSolution5.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpSolution5;

[Dependency(ReplaceServices = true)]
public class AbpSolution5BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpSolution5Resource> _localizer;

    public AbpSolution5BrandingProvider(IStringLocalizer<AbpSolution5Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
