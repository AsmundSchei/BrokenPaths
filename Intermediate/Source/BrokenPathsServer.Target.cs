using UnrealBuildTool;

public class BrokenPathsServerTarget : TargetRules
{
	public BrokenPathsServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("BrokenPaths");
	}
}
