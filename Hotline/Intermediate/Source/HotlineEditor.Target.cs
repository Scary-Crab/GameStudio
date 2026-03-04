using UnrealBuildTool;

public class HotlineEditorTarget : TargetRules
{
	public HotlineEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Hotline");
	}
}
