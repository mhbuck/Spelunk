using Spelunk.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelunk.Core
{
    // The delays are used to simulate data access of sorts
    // Currently not sure if this is the best way to handle the tasks
    public class BuildingService : IBuildingService
    {
        public Task<IList<BuildingModel>> GetAllBuildings(string filterName)
        {
            return Task.Delay(500).ContinueWith(t => (IList<BuildingModel>)DataSource.ModelSet.Where(b => string.IsNullOrWhiteSpace(filterName) || b.BuildingName.Contains(filterName)).ToList());
        }

        public Task<BuildingModel> GetBuildingById(int buildingId)
        {
            return Task.Delay(300).ContinueWith(t =>DataSource.ModelSet.Where(b => b.BuildingId == buildingId).SingleOrDefault());
        }

        public Task<BuildingModel> SaveBuilding(BuildingModel building)
        {
            return Task.Delay(300).ContinueWith(t =>
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
            });
        }
    }
}
