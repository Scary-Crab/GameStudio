using UnrealBuildTool;

public class HotlineServerTarget : TargetRules
{
	public HotlineServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Hotline");
	}
}
