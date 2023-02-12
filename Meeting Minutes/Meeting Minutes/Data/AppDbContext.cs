using Meeting_Minutes.Models;
using Microsoft.EntityFrameworkCore;

namespace Meeting_Minutes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meetings_Items>().HasKey(mi => new
            {
                mi.meetingId,
                mi.itemId
            });
            modelBuilder.Entity<Meetings_Items>().HasOne(m => m.Meeting).WithMany(mi => mi.Meeting_Item).HasForeignKey(m => m.meetingId);
            modelBuilder.Entity<Meetings_Items>().HasOne(m => m.Item).WithMany(mi => mi.Meeting_Item).HasForeignKey(m => m.itemId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet <MeetingTypes> MeetingTypes { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Meetings_Items> Meetings_Items { get; set; }
        public DbSet<ItemStatus> ItemStatus { get; set; }
    }

}
