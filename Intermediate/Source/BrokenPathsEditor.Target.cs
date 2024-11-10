using UnrealBuildTool;

public class BrokenPathsEditorTarget : TargetRules
{
	public BrokenPathsEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("BrokenPaths");
	}
}
