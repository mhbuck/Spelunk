using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spelunk.Web.Models
{
    public class ListingViewModel
    {
        public string TextFilter { get; set; }

        public IList<Core.Models.BuildingModel> Results { get; set; }
    }
}
