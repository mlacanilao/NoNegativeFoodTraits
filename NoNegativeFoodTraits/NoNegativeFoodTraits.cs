using BepInEx;
using HarmonyLib;

namespace NoNegativeFoodTraits
{
    internal static class ModInfo
    {
        internal const string Guid = "omegaplatinum.elin.nonegativefoodtraits";
        internal const string Name = "No Negative Food Traits";
        internal const string Version = "1.1.1.0";
    }

    [BepInPlugin(GUID: ModInfo.Guid, Name: ModInfo.Name, Version: ModInfo.Version)]
    internal class NoNegativeFoodTraits : BaseUnityPlugin
    {
        internal static NoNegativeFoodTraits Instance { get; private set; }
        
        private void Start()
        {
            Instance = this;
            
            Harmony.CreateAndPatchAll(type: typeof(Patcher));
        }
        
        internal static void Log(object payload)
        {
            Instance.Logger.LogInfo(data: payload);
        }
    }
}