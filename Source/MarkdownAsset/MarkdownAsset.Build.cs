// Copyright (C) 2024 Gwaredd Mountain - All Rights Reserved.

using UnrealBuildTool;

public class MarkdownAsset : ModuleRules
{
    public MarkdownAsset( ReadOnlyTargetRules Target ) : base( Target )
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange( new string[] {
            "Core",
            "CoreUObject",
        });

        //PrivateIncludePaths.AddRange( new string[] {
        //    "Runtime/MarkdownAsset/Private",
        //});
    }
}
