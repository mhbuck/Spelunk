using Spelunk.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelunk.Core
{
    public class BuildingService : IBuildingService
    {
        

        public IList<BuildingModel> GetAllBuildings(string filterName)
        {
            return DataSource.ModelSet.Where(b => string.IsNullOrWhiteSpace(filterName) || b.BuildingName.Contains(filterName)).ToList();
        }

        public BuildingModel GetBuildingById(int buildingId)
        {
            return DataSource.ModelSet.Where(b => b.BuildingId == buildingId).SingleOrDefault();
        }

        public BuildingModel SaveBuilding(BuildingModel building)
        {
            if (building.BuildingId == 0)
            {
                building.BuildingId = DataSource.ModelSet.Count;
                DataSource.ModelSet.Add(building);
            }
            else
            {
                var buildingModel = DataSource.ModelSet.Where(b => b.BuildingId == building.BuildingId).Single();

                buildingModel.BuildingName = building.BuildingName;
                buildingModel.Area = building.Area;
            }

            return building;
        }
    }
}
