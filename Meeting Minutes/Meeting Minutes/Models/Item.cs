using System.ComponentModel.DataAnnotations;

namespace Meeting_Minutes.Models
{
    public class Item
    {
        [Key]
        public int itemId { get; set; }

        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        public DateTime DueDate { get; set; }

        public string CurrentStatus { get; set; }

        //Relationships

        public List<Meetings_Items> Meeting_Item { get; set; }

        public List<ItemStatus> ItemStatus { get; set; }

        //User

        public int UserId { get; set; }
        public User User { get; set; }  
    }
}
