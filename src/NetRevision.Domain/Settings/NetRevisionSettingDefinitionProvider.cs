using Volo.Abp.Settings;

namespace NetRevision.Settings;

public class NetRevisionSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NetRevisionSettings.MySetting1));
    }
}
