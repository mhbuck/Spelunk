using Spelunk.Core;
using Spelunk.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Spelunk.Api.Controllers
{
    public class BuildingController : ApiController, IBuildingService
    {
        private IBuildingService _buildingService;
        public BuildingController ()
        {
            this._buildingService = new BuildingService();
        }

        [HttpGet("api/Buildings")]
        public Task<IList<BuildingModel>> GetAllBuildings(string filterName = "")
        {
            return this._buildingService.GetAllBuildings(filterName);
        }

        [HttpGet("api/Buildings/{buildingId:int}")]
        public Task<BuildingModel> GetBuildingById(int buildingId)
        {
            return this._buildingService.GetBuildingById(buildingId);
        }

        [HttpPost("api/Buildings")]
        public Task<BuildingModel> SaveBuilding(BuildingModel building)
        {
            return this.SaveBuilding(building);
        }
    }
}
