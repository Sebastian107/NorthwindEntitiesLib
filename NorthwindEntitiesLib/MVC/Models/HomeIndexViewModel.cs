using System.Collections.Generic;
using NorthwindEntitiesLib;

namespace MVC.Models
{
    public class HomeIndexViewModel
    {
        public int VisitorCount;
        public IList<Category> Categories { get; set; }
        public IList<Product> Products { get; set; }
    }
}