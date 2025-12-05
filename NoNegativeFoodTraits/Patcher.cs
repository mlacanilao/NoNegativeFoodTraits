using NoNegativeFoodTraits.Patches;
using HarmonyLib;

namespace NoNegativeFoodTraits
{
    public class Patcher
    {
        [HarmonyPostfix]
        [HarmonyPatch(declaringType: typeof(Card), methodName: nameof(Card.Create))]
        public static void CardCreate(Thing __instance)
        {
            CardPatch.CreatePostfix(__instance: __instance);
        }
        
        [HarmonyPrefix]
        [HarmonyPatch(declaringType: typeof(TraitDryBrick), methodName: nameof(TraitDryBrick.OnProduce))]
        public static bool TraitDryBrickOnProduce()
        {
            return TraitDryBrickPatch.OnProducePrefix();
        }
        
        [HarmonyPrefix]
        [HarmonyPatch(declaringType: typeof(TraitAgingShelf), methodName: nameof(TraitAgingShelf.OnProduce))]
        public static bool TraitAgingShelfOnProduce()
        {
            return TraitAgingShelfPatch.OnProducePrefix();
        }
        
        [HarmonyPrefix]
        [HarmonyPatch(declaringType: typeof(ElementContainer), methodName: nameof(ElementContainer.SetBase), argumentTypes: new[] { typeof(int), typeof(int), typeof(int) })]
        public static bool ElementContainerSetBase(ElementContainer __instance, int v)
        {
            return ElementContainerPatch.SetBasePrefix(__instance: __instance, v: v);
        }
        
        [HarmonyPrefix]
        [HarmonyPatch(declaringType: typeof(ElementContainer), methodName: nameof(ElementContainer.ModBase))]
        public static bool ElementContainerModBase(ElementContainer __instance, int ele, int v)
        {
            return ElementContainerPatch.ModBasePrefix(__instance: __instance, ele: ele, v: v);
        }
    }
}