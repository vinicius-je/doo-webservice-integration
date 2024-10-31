using WebServiceIntegration.Domain.DTOs;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Domain.Shared;
using WebServiceIntegration.Transform.Factory.Interfaces;

namespace WebServiceIntegration.Transform.Factory.Factories
{
    public class EntityAbstractFactory<Dto, Entity> : IEntityAbstractFactory<Dto, Entity>
        where Dto : BaseDTO
        where Entity : BaseEntity, new()
    {
        public Entity CreateEntity(Dto request)
        {
            return new EntityShared().CreateEntity<Entity, Dto>(request);
        }
    }
}
