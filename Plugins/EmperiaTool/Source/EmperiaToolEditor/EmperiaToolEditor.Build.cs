using UnrealBuildTool;

public class EmperiaToolEditor : ModuleRules
{
    public EmperiaToolEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        bUsePrecompiled=true;
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        
        PublicDependencyModuleNames.AddRange(
            new string[]
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
                "WebBrowser",
                "Networking",
                "Sockets"
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
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
                "MovieRenderPipelineCore",
                "UMG",
                "WebBrowser",
                "Networking",
                "Sockets"
            }
        );
    }
}