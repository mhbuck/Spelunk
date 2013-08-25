using Spelunk.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelunk.Core
{
    public static class DataSource
    {
        public static IList<BuildingModel> ModelSet = new List<BuildingModel>()
            {
                new BuildingModel() { BuildingId = 1, BuildingName = "Building A", Area = 700.05M },
                new BuildingModel() { BuildingId = 2, BuildingName = "Building B", Area = 300.00M },
                new BuildingModel() { BuildingId = 3, BuildingName = "Building C", Area = 250.10M },
                new BuildingModel() { BuildingId = 4, BuildingName = "Building D", Area = 400.00M },
                new BuildingModel() { BuildingId = 5, BuildingName = "Building E", Area = 800.00M },
                new BuildingModel() { BuildingId = 6, BuildingName = "Building F", Area = 100.00M },
                new BuildingModel() { BuildingId = 7, BuildingName = "Building G", Area = 900.00M },
            };
    }
}
