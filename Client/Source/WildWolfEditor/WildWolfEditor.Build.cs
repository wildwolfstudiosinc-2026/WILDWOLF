using UnrealBuildTool;

public class WildWolfEditor : ModuleRules
{
    public WildWolfEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new[]
        {
            "Core",
            "CoreUObject",
            "Engine",
            "UnrealEd",
            "WildWolf"
        });
    }
}
