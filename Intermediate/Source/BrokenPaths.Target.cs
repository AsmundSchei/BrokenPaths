using UnrealBuildTool;

public class BrokenPathsTarget : TargetRules
{
	public BrokenPathsTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("BrokenPaths");
	}
}
