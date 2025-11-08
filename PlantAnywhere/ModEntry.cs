using MelonLoader;

namespace PlantAnywhere;

public class ModEntry : MelonMod
{
    public override void OnInitializeMelon()
    {
        var harmony = new HarmonyLib.Harmony("PlantAnywhere");
        harmony.PatchAll();
    }
}