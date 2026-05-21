using AbpSolution5.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpSolution5.Permissions;

public class AbpSolution5PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpSolution5Permissions.GroupName);

        var booksPermission = myGroup.AddPermission(AbpSolution5Permissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AbpSolution5Permissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AbpSolution5Permissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AbpSolution5Permissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpSolution5Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpSolution5Resource>(name);
    }
}
