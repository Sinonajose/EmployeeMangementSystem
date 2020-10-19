using EmployeeMangementSystem.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EmployeeMangementSystem.Permissions
{
    public class EmployeeMangementSystemPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(EmployeeMangementSystemPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(EmployeeMangementSystemPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<EmployeeMangementSystemResource>(name);
        }
    }
}
