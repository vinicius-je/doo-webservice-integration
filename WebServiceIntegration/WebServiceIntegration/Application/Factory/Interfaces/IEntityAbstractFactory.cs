using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Domain.Entities;

namespace WebServiceIntegration.Application.Factory.Interfaces
{

    public interface IEntityAbstractFactory<Dto, Entity>
        where Dto : BaseDTO
        where Entity : BaseEntity
    {
        Entity CreateEntity(Dto request);
    }
}
