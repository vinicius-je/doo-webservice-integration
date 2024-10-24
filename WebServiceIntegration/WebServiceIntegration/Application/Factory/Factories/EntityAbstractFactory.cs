using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.Factory.Interfaces;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Domain.Shared;

namespace WebServiceIntegration.Application.Factory.Factories
{
    public class EntityAbstractFactory<Dto, Entity> : IEntityAbstractFactory<Dto, Entity>
        where Dto : BaseDTO
        where Entity : BaseEntity, new()
    {
        public Entity CreateEntity(Dto request)
        {
            return new EntidadeShared().InstanciarEntidade<Entity, Dto>(request);
        }
    }
}
