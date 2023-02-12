using System.ComponentModel.DataAnnotations;

namespace Meeting_Minutes.Models
{
    public class ItemStatus
    {
        [Key]
        public int StatusId { get; set; }

        public string Status { get; set; }

        public DateTime StatusDate { get; set; }

        //Relationships

        public int itemId { get; set; }
        public Item item { get; set; }

    }
}
