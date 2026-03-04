using UnrealBuildTool;

public class HotlineClientTarget : TargetRules
{
	public HotlineClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Hotline");
	}
}
