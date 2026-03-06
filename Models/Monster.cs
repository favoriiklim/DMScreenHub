namespace DMScreen.Client.Models
{
    public class Monster
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = "İnsansı";
        public string Alignment { get; set; } = "Tarafsız";
        
        public int ArmorClass { get; set; } = 10;
        public int MaxHitPoints { get; set; } = 10;
        public int CurrentHitPoints { get; set; } = 10;
        public int Speed { get; set; } = 30;
        public string ChallengeRating { get; set; } = "0";

        public int Strength { get; set; } = 10;
        public int Dexterity { get; set; } = 10;
        public int Constitution { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int Wisdom { get; set; } = 10;
        public int Charisma { get; set; } = 10;

        public string Description { get; set; } = string.Empty;
        public string Actions { get; set; } = string.Empty;
    }
}