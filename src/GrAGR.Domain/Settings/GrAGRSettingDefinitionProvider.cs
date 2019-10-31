using Volo.Abp.Settings;

namespace GrAGR.Settings
{
    public class GrAGRSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(GrAGRSettings.MySetting1));
        }
    }
}
