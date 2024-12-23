namespace PracticalExpamle_For_Teaching.Model
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public User? User { get; set; }
        public Product? Product { get; set; }
    }
}
