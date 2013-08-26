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
        Task<IList<BuildingModel>> GetAllBuildings(string filterName);

        Task<BuildingModel> GetBuildingById(int buildingId);

        Task<BuildingModel> SaveBuilding(BuildingModel building);
    }
}
