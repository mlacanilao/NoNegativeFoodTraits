namespace NoNegativeFoodTraits.Patches
{
    public class TraitAgingShelfPatch
    {
        public static bool OnProducePrefix()
        {
            return false;
        }
    }
}