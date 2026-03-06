namespace DMScreen.Client.Models
{
    public class Wall
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
    }
}