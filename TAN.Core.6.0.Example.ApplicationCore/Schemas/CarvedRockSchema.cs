using System;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using TAN.Core._6._0.Example.ApplicationCore.Queries;

namespace TAN.Core._6._0.Example.ApplicationCore.Schemas
{
    public class CarvedRockSchema : Schema
    {
        public CarvedRockSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetService<CarvedRockQuery>();
        }
    }
}