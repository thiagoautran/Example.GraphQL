using GraphQL.Types;
using TAN.Core._6._0.Example.ApplicationCore.Entities;

namespace TAN.Core._6._0.Example.ApplicationCore.Types
{
    public class ProductType : ObjectGraphType<ProductEntity>
    {
        public ProductType()
        {
            Field(product => product.Id);
            Field(product => product.Name);
            Field(product => product.Description);
        }
    }
}