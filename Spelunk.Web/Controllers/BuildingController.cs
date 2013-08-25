using Spelunk.Core;
using Spelunk.Core.Models;
using Spelunk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Spelunk.Web.Controllers
{
    public class BuildingController : Controller
    {
        private IBuildingService _buildingService;

        public BuildingController(IBuildingService buildingService)
        {
            this._buildingService = buildingService;
        }

        public ActionResult Index(string textFilter)
        {
            var buildings = this._buildingService.GetAllBuildings(textFilter);

            ListingViewModel model = new ListingViewModel();
            model.TextFilter = textFilter;
            model.Results = buildings;

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int? Id)
        {
            BuildingModel model = new BuildingModel();

            if (Id.HasValue)
            {
                model = this._buildingService.GetBuildingById(Id.Value);
            }
            else
            {
                model = new BuildingModel();
            }

            return this.View(model);
        }

        [HttpPost]
        public ActionResult Edit(BuildingModel model)
        {
            this._buildingService.SaveBuilding(model);

            return this.RedirectToAction("Edit", new { id = model.BuildingId });
        }
    }
}