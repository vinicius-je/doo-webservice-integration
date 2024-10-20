using WebServiceIntegration.Application.DTOs;

namespace WebServiceIntegration.Application.WebServiceApplication.Interfaces
{
    public interface IWebService<T> where T : BaseDTO
    {
        Task<ICollection<T>> GetEntity(string endpoint);
    }
}
