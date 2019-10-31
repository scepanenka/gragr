using GrAGR.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace GrAGR.Permissions
{
    public class GrAGRPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(GrAGRPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(GrAGRPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<GrAGRResource>(name);
        }
    }
}
