using Portfolio_NetCore_BL;
using Portfolio_NetCore_DAL;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio_NetCore_API
{
    public class DataSeeder
    {
        public static void Initialize(APIDomain_DbContext context)
        {
            if (!context.Plants.Any())
            {
                var plants = new List<Plant>()
                {
                    new Plant { /*Id = 1,*/ Name = "TestPlant1", Description = "Test Plant Description 1", SeasonId = 1, PlantTypeId = 1},
                    new Plant { /*Id = 2,*/ Name = "TestPlant2", Description = "Test Plant Description 2", SeasonId = 2, PlantTypeId = 2}
                };
                context.Plants.AddRange(plants);
                context.SaveChanges();
            }

            if (!context.PlantTypes.Any())
            {
                var planttypes = new List<PlantType>()
                {
                    new PlantType { /* Id = 1 */ Name = "PlantType1", Description = "Plant Type Description 1"},
                    new PlantType { /* Id = 2 */ Name = "PlantType2", Description = "Plant Type Description 2"}
                };
                context.PlantTypes.AddRange(planttypes);
                context.SaveChanges();
            }
            if (!context.Seasons.Any())
            {
                var seasons = new List<Season>()
                {
                    new Season { /* Id = 1 */ Name = "Season1", Description = "Season Description 1" },
                    new Season { /* Id = 2 */ Name = "Season2", Description = "Season Description 2" }
                };
                context.Seasons.AddRange(seasons);
                context.SaveChanges();
            }
        }
    }
}
