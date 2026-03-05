using Blazored.LocalStorage;
using DMScreen.Client.Models;

namespace DMScreen.Client.Services
{
    public class WikiService
    {
        private readonly ILocalStorageService _localStorage;
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Monster> Monsters { get; set; } = new List<Monster>();

        public WikiService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task LoadDataAsync()
        {
            var savedItems = await _localStorage.GetItemAsync<List<Item>>("wiki_items");
            if (savedItems != null && savedItems.Count > 0)
            {
                Items = savedItems;
            }

            var savedMonsters = await _localStorage.GetItemAsync<List<Monster>>("wiki_monsters");
            if (savedMonsters != null && savedMonsters.Count > 0)
            {
                Monsters = savedMonsters;
            }
        }

        public async Task SaveDataAsync()
        {
            await _localStorage.SetItemAsync("wiki_items", Items);
            await _localStorage.SetItemAsync("wiki_monsters", Monsters);
        }
    }
}