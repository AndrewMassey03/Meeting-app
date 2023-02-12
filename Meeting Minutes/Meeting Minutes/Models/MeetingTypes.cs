using System.ComponentModel.DataAnnotations;

namespace Meeting_Minutes.Models
{
    public class MeetingTypes
    {
        [Key]
        public int TypeId { get; set; }
        public string Name { get; set; }

        //Relationships

        public List<Meeting> Meetings { get; set; }


       
    }
}
