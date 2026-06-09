using UnrealBuildTool;

public class WildWolf : ModuleRules
{
    public WildWolf(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new[]
        {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "EnhancedInput",
            "GameplayAbilities",
            "GameplayTags",
            "GameplayTasks",
            "MassEntity",
            "Niagara",
            "UMG",
            "OpenXR"
        });

        PrivateDependencyModuleNames.AddRange(new[]
        {
            "Slate",
            "SlateCore",
            "HTTP",
            "Json",
            "JsonUtilities"
        });
    }
}
