// Purpose: Seed data for the database.

using Domain;

namespace Persistence
{
  public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
          // If there are any activities in the database, don't do anything.
            if (context.Activities.Any()) return;

          // Otherwise, create a list of activities and add them to the database.
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Prayer Meeting",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Prayer Meeting",
                    Category = "prayer",
                    City = "Colleyville",
                    Venue = "RCCG Glory House Church at Colleyville",
                },
                new Activity
                {
                    Title = "Prayer Meeting",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Prayer Meeting",
                    Category = "prayer",
                    City = "Colleyville",
                    Venue = "RCCG Glory House Church at Colleyville",
                },
                new Activity
                {
                    Title = "Holy Communion Service",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Holy Communion Service",
                    Category = "communion",
                    City = "Collleyville",
                    Venue = "RCCG Glory House Church at Colleyville",
                },
                new Activity
                {
                    Title = "YADAH Concert",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Praise and Worship Concert",
                    Category = "music",
                    City = "Colleyville",
                    Venue = "RCCG Glory House Church at Colleyville",
                },
                new Activity
                {
                    Title = "Church Picnic",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Church Picnic",
                    Category = "culture",
                    City = "Grand Prairie",
                    Venue = "Lynn Creek Park",
                },
                new Activity
                {
                    Title = "Prayer Meeting",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Prayer Meeting",
                    Category = "prayer",
                    City = "Colleyville",
                    Venue = "RCCG Glory House Church at Colleyville",
                },
                new Activity
                {
                    Title = "Children's Day",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Children's Day",
                    Category = "culture",
                    City = "Colleyville",
                    Venue = "RCCG Glory House Church at Colleyville",
                },
                new Activity
                {
                    Title = "Bible Study",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Bible Study",
                    Category = "service",
                    City = "Colleyville",
                    Venue = "RCCG Glory House Church at Colleyville",
                },
                new Activity
                {
                    Title = "Future Activity 1",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Activity 2 months ago",
                    Category = "music",
                    City = "Irving",
                    Venue = "Toyota Music Factory",
                },
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Activity 8 months in future",
                    Category = "film",
                    City = "Dallas",
                    Venue = "AMC NorthPark 15",
                }
            };

            // Add range of activities to memory.
            await context.Activities.AddRangeAsync(activities);
            // Save changes to database.
            await context.SaveChangesAsync();
        }
    }
}