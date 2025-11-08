using HarmonyLib;
using Il2CppReloaded.Gameplay;

namespace PlantAnywhere.Framework;

[HarmonyPatch(typeof(Board), nameof(Board.CanPlantAt))]
public class BoardPatch
{
    public static void Postfix(ref PlantingReason __result)
    {
        __result = PlantingReason.Ok;
    }
}