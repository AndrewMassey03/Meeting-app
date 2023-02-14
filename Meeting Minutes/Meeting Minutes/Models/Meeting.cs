using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meeting_Minutes.Models
{
    public class Meeting
    {
        [Key]
        public int meetingID { get; set; }

        public int meetingNumber { get; set; }

        public DateTime meetingDate { get; set; }

        //Meeting Types

        public int MeetingTypeId { get; set; }
        [ForeignKey("MeetingTypeId")]
        public MeetingTypes meetingType { get; set; }

        //Relationships
        public List<Meetings_Items> Meeting_Item { get; set; }

       
    }
}
