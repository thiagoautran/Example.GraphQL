using GraphQL.Types;
using TAN.Core._6._0.Example.ApplicationCore.Entities;

namespace TAN.Core._6._0.Example.ApplicationCore.Types
{
    public class ProductType : ObjectGraphType<ProductEntity>
    {
        public ProductType()
        {
            Name = "Produto";
            Description = "Descrição do Produto";
            Field(product => product.Id, nullable: false).Description("Identificador unico do produto.");
            Field(product => product.Name, nullable: true).Description("Nome do produto.");
            Field(product => product.Description, nullable: true).Description("Descrição do produto.");
        }
    }
}