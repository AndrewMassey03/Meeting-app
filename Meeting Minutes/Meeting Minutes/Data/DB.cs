using Meeting_Minutes.Models;
using Microsoft.EntityFrameworkCore;

namespace Meeting_Minutes.Data
{
    public class DB : DbContext
    {
        public DbSet<MeetingTypes> MeetingTypes { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Meetings_Items> Meetings_Items { get; set; }
        public DbSet<ItemStatus> ItemStatus { get; set; }
    }
}
