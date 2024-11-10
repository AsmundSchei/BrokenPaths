using UnrealBuildTool;

public class BrokenPathsClientTarget : TargetRules
{
	public BrokenPathsClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("BrokenPaths");
	}
}
