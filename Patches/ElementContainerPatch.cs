namespace NoNegativeFoodTraits.Patches
{
    public class ElementContainerPatch
    {
        public static bool SetBasePrefix(ElementContainer __instance, int v)
        {
            if (__instance?.Card?.IsFood == true && v < 0)
            {
                return false;
            }
            
            return true;
        }
    }
}