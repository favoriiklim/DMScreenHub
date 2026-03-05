namespace DMScreen.Client.Models
{
    public class Monster
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        // Temel FRP Statları
        public int ArmorClass { get; set; } = 10;
        public int MaxHitPoints { get; set; } = 10;
        public int CurrentHitPoints { get; set; } = 10;
        public int Speed { get; set; } = 30; // ft veya kare cinsinden hareket hızı
        
        public string ChallengeRating { get; set; } = "1/4"; // Zorluk derecesi
        
        // Harita üzerindeki token (ikon) resmi için
        public string ImageUrl { get; set; } = "/images/default-monster.png"; 
    }
}