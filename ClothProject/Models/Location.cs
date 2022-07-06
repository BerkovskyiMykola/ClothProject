namespace ClothProject.Models
{
    public class Location
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Altitude { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
