using CDExcellent.Context;
using System.Collections.Generic;

namespace CDExcellent.Areas.Admin.Controllers
{
    internal class Product_Category
    {
        public Product_Category()
        {
        }

        public List<CreatePlanVisit> ListCategory { get; internal set; }
        public List<AddNewUser> ListProduct { get; internal set; }
    }
}