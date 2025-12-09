using UnrealBuildTool;

public class EchoesClientTarget : TargetRules
{
	public EchoesClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Echoes");
	}
}
