using UnrealBuildTool;

public class EchoesServerTarget : TargetRules
{
	public EchoesServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Echoes");
	}
}
