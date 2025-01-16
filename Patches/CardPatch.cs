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
            
            List<Element> negativeElement = new List<Element>();
            foreach (Element element in __instance.elements.dict.Values)
            {
                if (element.Value <= 0)
                {
                    negativeElement.Add(element);
                }
            }
            
            foreach (Element element in negativeElement)
            {
                __instance.elements.SetTo(id: element.id, v: 0);
            }
        }
    }
}