using Refit;
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
        [Get("/api/Buildings")]
        Task<IList<BuildingModel>> GetAllBuildings(string filterName);

        [Get("/api/Buildings/{buildingid}")]
        Task<BuildingModel> GetBuildingById(int buildingId);

        [Post("/api/building/SaveBuilding")]
        Task<BuildingModel> SaveBuilding([Body] BuildingModel building);
    }
}
