using Spelunk.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelunk.Core
{
    public interface IBuildingService
    {
        IList<BuildingModel> GetAllBuildings(string filterName);

        BuildingModel GetBuildingById(int buildingId);

        BuildingModel SaveBuilding(BuildingModel building);
    }
}
