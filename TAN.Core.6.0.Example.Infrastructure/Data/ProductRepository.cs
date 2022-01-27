using System.Collections.Generic;
using TAN.Core._6._0.Example.ApplicationCore.Entities;
using TAN.Core._6._0.Example.ApplicationCore.Interfaces;

namespace TAN.Core._6._0.Example.Infrastructure.Schemas
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<ProductEntity> GetAll()
        {
            return new List<ProductEntity>
            {
                new ProductEntity
                {
                    Id = 1,
                    Name = "test",
                    Description = "test"
                }
            };
        }
    }
}