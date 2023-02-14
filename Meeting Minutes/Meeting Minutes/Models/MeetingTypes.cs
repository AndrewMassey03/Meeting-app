using System.ComponentModel.DataAnnotations;

namespace Meeting_Minutes.Models
{
    public class MeetingTypes
    {
        [Key]
        public int MeetingTypeId { get; set; }
        public string Name { get; set; }

        //Relationships

        public List<Meeting> Meeting { get; set; }


       
    }
}
