namespace Meeting_Minutes.Models
{
    public class Meetings_Items
    {
        public int meetingId { get; set; }
        public Meeting Meeting { get; set; }

        public int itemId { get; set; }
        public Item Item { get; set; }
    }
}
