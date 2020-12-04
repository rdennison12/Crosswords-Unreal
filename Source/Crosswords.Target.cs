// Copyright 2020 Rick Dennison

using UnrealBuildTool;
using System.Collections.Generic;

public class CrosswordsTarget : TargetRules
{
	public CrosswordsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Crosswords" } );
	}
}
