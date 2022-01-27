using System;
using GraphQL.Types;
using TAN.Core._6._0.Example.ApplicationCore.Queries;

namespace TAN.Core._6._0.Example.ApplicationCore.Schemas
{
    public class CarvedRockSchema : Schema
    {
        public CarvedRockSchema(CarvedRockQuery query, IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = query;
        }
    }
}