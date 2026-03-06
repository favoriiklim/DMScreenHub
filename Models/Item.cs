namespace DMScreen.Client.Models
{
    public class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = "Eşya"; 
        public string Rarity { get; set; } = "Yaygın";
        public int Value { get; set; }
        public double Weight { get; set; }
        public string Description { get; set; } = string.Empty;
        public string MechanicalRules { get; set; } = string.Empty; 
    }
}