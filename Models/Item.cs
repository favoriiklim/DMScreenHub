namespace DMScreen.Client.Models
{
    public class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Her eşyaya benzersiz bir kimlik veriyoruz
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; } = "Misc"; // Weapon, Armor, Potion, Scroll vb.
        public string Rarity { get; set; } = "Common"; // Common, Rare, Legendary
        public int Weight { get; set; } = 0;
        public int Value { get; set; } = 0; // Altın/Gümüş değeri
        public bool IsHidden { get; set; } = false; // DM'in oyuncudan gizlediği eşyalar için
    }
}