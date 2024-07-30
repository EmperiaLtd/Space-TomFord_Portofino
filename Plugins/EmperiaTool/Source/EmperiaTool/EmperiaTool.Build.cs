// Copyright Epic Games, Inc. All Rights Reserved.
using System;
using System.Collections.Generic;
using System.IO;
using UnrealBuildTool;

public class EmperiaTool : ModuleRules
{
	
	
    public EmperiaTool(ReadOnlyTargetRules Target) : base(Target)
	{
		//Plugin configuration
        bUsePrecompiled=true;
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[]
			{
				// ... add public include paths required here ...
			}
		);
		PrivateIncludePaths.AddRange(
			new string[]
			{
				// ... add other private include paths required here ...
			}
		);
		PublicDependencyModuleNames.AddRange(
			new[]
			{
				"Core",
				"UMG",
				"UMGEditor",
				"Blutility",
				"MaterialEditor",
				"CoreUObject",
				"JsonUtilities",
				"MediaAssets", 
				"WebBrowserWidget", 
				"PlacementMode",
				"LevelEditor",
				 "SlateCore",
				 "OpenSSL",
				 "UnrealEd",
				 "AssetTools", 
				 "PCG"
				 // ... add other public dependencies that you statically link with here ...
			}
		);


		PrivateDependencyModuleNames.AddRange(
			new[]
			{
				"Projects",
				"CoreUObject",
				"InputCore",
				"MaterialEditor",
				"UnrealEd",
				"ToolMenus",
				"Engine",
				"Slate",
				"SlateCore",
				"MessageLog",
				"HTTP",
				"HTTPServer",
				"Json",
				"JsonUtilities",
				"EditorScriptingUtilities", 
				"ImageWriteQueue",
				"WebBrowser", 
				"WebBrowserTexture",
				"ImageWrapper",
				"RenderCore",
				"OpenSSL",
				"MovieRenderPipelineCore"
				// ... add private dependencies that you statically link with here ...	
			}
		);
		AddEngineThirdPartyPrivateStaticDependencies(Target, "OpenSSL");
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
		);
	}
}
