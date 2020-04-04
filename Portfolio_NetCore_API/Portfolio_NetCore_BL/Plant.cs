using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Portfolio_NetCore_BL
{
    public class Plant
    {
        public int PlantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SeasonId { get; set; }
        public int PlantTypeId { get; set; }
    }
}
