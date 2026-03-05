namespace DMScreen.Client.Models
{
    public class Token
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        
        public double X { get; set; } 
        public double Y { get; set; } 
        
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
    }
}