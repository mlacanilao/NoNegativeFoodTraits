namespace NoNegativeFoodTraits.Patches
{
    public static class TraitDryBrickPatch
    {
        public static bool OnProducePrefix()
        {
            return false;
        }
    }
}