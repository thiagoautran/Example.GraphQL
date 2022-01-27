using GraphQL.Types;
using TAN.Core._6._0.Example.ApplicationCore.Entities;

namespace TAN.Core._6._0.Example.ApplicationCore.Types
{
    public class ProductType : ObjectGraphType<ProductEntity>
    {
        public ProductType()
        {
            Field(product => product.Id).Description("Identificador unico do produto.");
            Field(product => product.Name).Description("Nome do produto.");
            Field(product => product.Description).Description("Descrição do produto.");
        }
    }
}