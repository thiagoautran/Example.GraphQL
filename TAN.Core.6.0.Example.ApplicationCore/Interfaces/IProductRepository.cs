using System.Collections.Generic;
using TAN.Core._6._0.Example.ApplicationCore.Entities;

namespace TAN.Core._6._0.Example.ApplicationCore.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<ProductEntity> GetAll();
    }
}