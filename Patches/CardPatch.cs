using System.Collections.Generic;

namespace NoNegativeFoodTraits.Patches
{
    public static class CardPatch
    {
        public static void CreatePostfix(Thing __instance)
        {
            if (__instance.IsFood == false)
            {
                return;
            }
            
            List<int> negativeElementIds = new List<int>();
            foreach (Element element in __instance.elements.dict.Values)
            {
                if (element.Value <= 0)
                {
                    negativeElementIds.Add(element.id);
                }
            }
            
            foreach (int elementId in negativeElementIds)
            {
                __instance.elements?.SetTo(id: elementId, v: 0);
            }
        }
    }
}