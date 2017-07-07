using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> Pies
        {
            get
            {
                return new List<Pie>
                {
                    new Pie{PieId = 1, Name = "Strawberry Pie", Price = 15.95M, ShortDescription = "Lorem Ipsum", LongDescription = "Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum", Category = _categoryRepository.Categories.ToList()[0]},
                    new Pie{PieId = 2, Name = "Blueberry Pie", Price = 18.95M, ShortDescription = "Lorem Ipsum", LongDescription = "Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum", Category = _categoryRepository.Categories.ToList()[0]}
                };
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
