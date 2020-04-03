using UnlockAllWondersAndLandmarks.OptionsFramework.Attibutes;

namespace UnlockAllWondersAndLandmarks
{
    [Options("UnlockAllWondersAndLandmarks.xml", "CSL-UnlockAllWondersAndLandmarks.xml")]
    public class Options
    {
        public Options()
        {
            unlockUniqueBuildings = true;
            unlockDeluxeLandmarks = true;
            unlockEuroLandmarks = true;
            unlockWonders = true;
            unlockAfterDarkLandmarks = false;
            unlockSnowfallLandmarks = false;
            unlockNaturalDisastersLandmarks = false;
            unlockGreenCitiesLandmarks = false;
            unlockConcertsLandmarks = false;
            unlockParklifeLandmarks = false;
        }

        [Checkbox("Débloque les Monuments Uniques (Niveaux I à VI)")]
        public bool unlockUniqueBuildings { set; get; }
        [Checkbox("Débloque Monuments/Bâtiments de Luxe (Deluxe Edition requis)")]
        public bool unlockDeluxeLandmarks { set; get; }
        [Checkbox("Débloque les Monuments/Bâtiments Européen (European biome requis / Mod European Buildings Unlocker requis)")]
        public bool unlockEuroLandmarks { set; get; }
        [Checkbox("Débloque les Merveilles (a.k.a Monuments)")]
        public bool unlockWonders { set; get; }
        [Checkbox("Débloque les Monuments/Bâtiments d'After Dark (a.k.a Tourisme & Loisirs, DLC After Dark requis)")]
        public bool unlockAfterDarkLandmarks { set; get; }
        [Checkbox("Débloque les Monuments/Bâtiments de Snowfall (DLC Snowfall requis + Mod Winter biome/Winter Buildings Unlocker)")]
        public bool unlockSnowfallLandmarks { set; get; }
        [Checkbox("Débloque les Monuments/Bâtiments de Natural Disasters (DLC Natural Disasters requis)")]
        public bool unlockNaturalDisastersLandmarks { set; get; }
        [Checkbox("Débloque les Monuments/Bâtiments de Mass Transit (DLC Mass Transit requis)")]
        public bool unlockMassTransitLandmarks { set; get; }
        [Checkbox("Débloque les Monuments/Bâtiments de Green Cities (DLC Green Cities requis)")]
        public bool unlockGreenCitiesLandmarks { set; get; }
        [Checkbox("Débloque les Monuments/Bâtiments de Concerts (DLC Concerts DLC requis)")]
        public bool unlockConcertsLandmarks { set; get; }
        [Checkbox("Débloque les Monuments/Bâtiments de Parklife (DLC Parklife requis)")]
        public bool unlockParklifeLandmarks { set; get; }
    }
}
