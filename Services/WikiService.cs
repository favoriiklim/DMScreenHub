using DMScreen.Client.Models;

namespace DMScreen.Client.Services
{
    public class WikiService
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Monster> Monsters { get; set; } = new List<Monster>();

        public WikiService()
        {
            // Sisteme başlarken test edebilmemiz için birkaç örnek veri
            Items.Add(new Item { Name = "Şifa İksiri", Description = "2d4+2 can yeniler.", Type = "Potion", Value = 50 });
            Items.Add(new Item { Name = "Paslı Uzun Kılıç", Description = "1d8 kesici hasar.", Type = "Weapon", Value = 15 });

            Monsters.Add(new Monster { Name = "Sinsi Goblin", ArmorClass = 15, MaxHitPoints = 7, CurrentHitPoints = 7, ChallengeRating = "1/4" });
            Monsters.Add(new Monster { Name = "Mağara Ayısı", ArmorClass = 12, MaxHitPoints = 34, CurrentHitPoints = 34, ChallengeRating = "2" });
        }
    }
}