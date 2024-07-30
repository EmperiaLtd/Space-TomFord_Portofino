using UnrealBuildTool;

public class EmperiaHTMLMenu : ModuleRules
{
    public EmperiaHTMLMenu(ReadOnlyTargetRules Target) : base(Target)
    {
	    bUsePrecompiled=true;
	    PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);


		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);


		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
                "UMG",
                "WebBrowser",
                "Networking",
                "Sockets",
                "Json", 
                "JsonUtilities"
            }
			);


		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
                "UMG",
                "WebBrowser",
                "Networking",
                "Sockets",
                "Json", 
                "JsonUtilities"
			}
			);


		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
			}
			);

		if (Target.bBuildEditor == true)
        {
            PrivateIncludePathModuleNames.AddRange(
                new string[]
                {
                        "UnrealEd",
                }
            );
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                        "UnrealEd",
                }
            );
        }
		/*PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"WebBrowserTexture",
			}
		);*/
    }
}
