namespace SuperAdventureLibrary.Items.Weapons {

    public class Weapon : Item {

        public int WeaponID { get; set; }
        public string WeaponName { get; set; }
        public string WeaponNamePlural { get; set; }
        public int MinDmg { get; set; }
        public int MaxDmg { get; set; }

    }
}