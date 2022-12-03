using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using KudlikCarsd.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

namespace KudlikCarsd
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class KudlikCarsd : BaseUnityPlugin
    {
        private const string ModId = "com.Kudlik.rounds.KudlikCars";
        private const string ModName = "KudlikCarsd";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "KUDLIK";
        public static KudlikCarsd? instance { get; private set; }
        void Awake()
        {
            instance = this;
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            CustomCard.BuildCard<BigChungus>();
            CustomCard.BuildCard<Carrrrrd> ();
            CustomCard.BuildCard<MegaGun>();
        }
    }
}
