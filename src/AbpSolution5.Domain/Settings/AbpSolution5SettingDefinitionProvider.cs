using Volo.Abp.Settings;

namespace AbpSolution5.Settings;

public class AbpSolution5SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpSolution5Settings.MySetting1));
    }
}
