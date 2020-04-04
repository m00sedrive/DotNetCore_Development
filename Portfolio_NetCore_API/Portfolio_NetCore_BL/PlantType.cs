using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Portfolio_NetCore_BL
{
    public class PlantType
    {
        public int PlantTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
