using Meeting_Minutes.Models;

namespace Meeting_Minutes.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //User
                if (!context.User.Any())
                {
                    context.User.AddRange(new List<User>()
                    {
                        new User()
                        {
                           
                            UserName = "Not Applicable",

                        },

                         new User()
                        {
                           
                            UserName = "Peter Wiles",

                        },

                          new User()
                        {
                            
                            UserName = "Kiran Derek Heyman",

                        },

                           new User()
                        {
                            
                            UserName = "Varushka Singh",

                        },


                    });
                    context.SaveChanges();
                }

                //Item
                if (!context.Item.Any())
                {
                    context.Item.AddRange(new List<Item>()
                    {
                        new Item()
                        {
                            ItemName = "Finalise SomeCompany Contract",
                            ItemDescription = "Resources for SomeCompany was discussed. PW advised that SomeCompany are looking for a Senior Developer and a Junior Developer.\n\nPeter to contact Employment Agencies with specifications",
                            DueDate = DateTime.Now,
                            CurrentStatus = "Open",
                            UserId = 2,
                        },

                        new Item()
                        {
                            ItemName = "Asset Management System",
                            ItemDescription = "Project is proceeding well and will be completed on time.\n\nPhase One is ready for testing",
                            DueDate = DateTime.Now,
                            CurrentStatus = "In Development",
                            UserId = 3,
                        },

                        new Item()
                        {
                            ItemName = "Some Other System.",
                            ItemDescription = "This system is complete and installed. Customer can be Invoiced",
                            DueDate = DateTime.Now,
                            CurrentStatus = "Awaiting Invoicing",
                            UserId = 4,
                        },

                         new Item()
                        {
                            ItemName = "Another System",
                            ItemDescription = "This System is complete and has been invoiced.",
                            DueDate = DateTime.Now,
                            CurrentStatus = "Closed",
                            UserId = 1,
                        },
                    });
                    context.SaveChanges();
                }
                //ItemStatus
                if (!context.ItemStatus.Any())
                {
                    context.ItemStatus.AddRange(new List<ItemStatus>()
                    {
                        new ItemStatus()
                        {
                            Status = "In Process",
                            StatusDate = DateTime.Now.AddDays(30),
                            itemId = 4, 
                        },

                        new ItemStatus()
                        {
                            Status = "Awaiting Invoicing",
                            StatusDate = DateTime.Now.AddDays(30),
                            itemId = 5,
                        },

                          new ItemStatus()
                        {
                            Status = "Open",
                            StatusDate = DateTime.Now.AddDays(-30),
                            itemId = 5,
                        },
                    });
                    context.SaveChanges();
                }
                //MeetingTypes
                if (!context.MeetingTypes.Any())
                {
                    context.MeetingTypes.AddRange(new List<MeetingTypes>()
                    {
                        new MeetingTypes()
                        {
                           
                            Name = "MANCO",
                        },

                        new MeetingTypes()
                        {
                            Name = "Finance",
                        },

                        new MeetingTypes()
                        {
                            Name = "Project Team Leader",
                        },
                    });
                    context.SaveChanges();
                }
                //Meeting
                if (!context.Meeting.Any())
                {
                    context.Meeting.AddRange(new List<Meeting>()
                    {
                       new Meeting()
                       {
                           meetingNumber = 1,
                           meetingDate= DateTime.Now.AddDays(-30),
                           MeetingTypeId = 3,
                           
                       },
                       new Meeting()
                       {
                           meetingNumber = 2,
                           meetingDate= DateTime.Now,
                           MeetingTypeId = 3,
                       },
                       new Meeting()
                       {
                           meetingNumber = 3,
                           meetingDate= DateTime.Now.AddDays(30),
                           MeetingTypeId = 3,
                       },
                    });
                    context.SaveChanges();
                }
                //Meeting_Items
                if (!context.Meetings_Items.Any())
                {
                    context.Meetings_Items.AddRange(new List<Meetings_Items>()
                    {
                        new Meetings_Items()
                        {
                            meetingId = 1,
                            itemId = 5,
                        },

                        new Meetings_Items()
                        {
                            meetingId = 2,
                            itemId = 4,
                        },
                         new Meetings_Items()
                        {
                            meetingId = 2,
                            itemId = 5,
                        },
                         new Meetings_Items()
                        {
                            meetingId = 2,
                            itemId = 6,
                        },
                         new Meetings_Items()
                        {
                            meetingId = 2,
                            itemId = 7,
                        },
                         new Meetings_Items()
                        {
                            meetingId = 3,
                            itemId = 4,
                        },
                          new Meetings_Items()
                        {
                            meetingId = 3,
                            itemId = 5,
                        },
                    });
                    context.SaveChanges();

                }
               
                

            }
        }
    }
}
