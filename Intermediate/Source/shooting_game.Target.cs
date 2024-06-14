using UnrealBuildTool;

public class shooting_gameTarget : TargetRules
{
	public shooting_gameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("shooting_game");
	}
}
