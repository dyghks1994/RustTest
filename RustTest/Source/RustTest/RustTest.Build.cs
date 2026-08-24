// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RustTest : ModuleRules
{
	public RustTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"RustTest",
			"RustTest/Player",
			"RustTest/Variant_Platforming",
			"RustTest/Variant_Platforming/Animation",
			"RustTest/Variant_Combat",
			"RustTest/Variant_Combat/AI",
			"RustTest/Variant_Combat/Animation",
			"RustTest/Variant_Combat/Gameplay",
			"RustTest/Variant_Combat/Interfaces",
			"RustTest/Variant_Combat/UI",
			"RustTest/Variant_SideScrolling",
			"RustTest/Variant_SideScrolling/AI",
			"RustTest/Variant_SideScrolling/Gameplay",
			"RustTest/Variant_SideScrolling/Interfaces",
			"RustTest/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
