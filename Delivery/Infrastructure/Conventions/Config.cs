using System;
using Delivery.Infrastructure.Entities;
using FluentNHibernate.Automapping;

namespace Delivery.Infrastructure.Conventions
{
    public class Config : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.IsSubclassOf(typeof(Entity));
        }
    }
}