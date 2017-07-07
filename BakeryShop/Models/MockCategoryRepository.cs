using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ CategoryId = 1, CategoryName = "Fruit Pies", Description = "All fruit pies!"},
                    new Category{ CategoryId = 1, CategoryName = "Cheese cakes", Description = "Delicious cheese cakes!"},
                    new Category{ CategoryId = 3, CategoryName = "Seasonal Pies", Description = "Seasonal pies!"}
                };
            }
        }
    }
}
