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
            
            foreach (Element element in __instance.elements.dict.Values)
            {   
                if (element.Value <= 0)
                {
                    __instance.elements.SetTo(id: element.id, v: 0);
                }
            }
        }
    }
}