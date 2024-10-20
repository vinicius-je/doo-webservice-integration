using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Domain.Entities;

namespace WebServiceIntegration.Application.Factory.Interfaces
{
    public interface IEntityAbstractFactory<Request, Response>
        where Request : BaseDTO
        where Response : BaseEntity
    {
        Response CreateEntity(Request request);
    }
}
