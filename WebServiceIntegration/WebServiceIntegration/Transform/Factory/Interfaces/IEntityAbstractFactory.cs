using WebServiceIntegration.Domain.DTOs;
using WebServiceIntegration.Domain.Entities;

namespace WebServiceIntegration.Transform.Factory.Interfaces
{

    public interface IEntityAbstractFactory<Dto, Entity>
        where Dto : BaseDTO
        where Entity : BaseEntity
    {
        Entity CreateEntity(Dto request);
    }
}
