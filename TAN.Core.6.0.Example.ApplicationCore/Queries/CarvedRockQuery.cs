using GraphQL.Types;
using TAN.Core._6._0.Example.ApplicationCore.Interfaces;
using TAN.Core._6._0.Example.ApplicationCore.Types;

namespace TAN.Core._6._0.Example.ApplicationCore.Queries
{
    public class CarvedRockQuery : ObjectGraphType
    {
        public CarvedRockQuery(IProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => productRepository.GetAll()
            );
        }
    }
}