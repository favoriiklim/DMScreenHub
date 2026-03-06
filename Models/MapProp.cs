namespace DMScreen.Client.Models
{
    public class MapProp
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty; 
        
        public double X { get; set; }
        public double Y { get; set; }
        
        // This is the foundation for the future DM/Player vision split
        public bool IsHidden { get; set; } = false;
    }
}