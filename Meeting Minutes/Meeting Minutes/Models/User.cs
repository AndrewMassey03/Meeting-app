using System.ComponentModel.DataAnnotations;

namespace Meeting_Minutes.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        //Relationships
        public List<Item> Items { get; set; }
    }
}
