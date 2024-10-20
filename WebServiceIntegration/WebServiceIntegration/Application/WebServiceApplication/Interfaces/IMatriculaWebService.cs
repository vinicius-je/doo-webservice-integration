using WebServiceIntegration.Application.DTOs;

namespace WebServiceIntegration.Application.WebServiceApplication.Interfaces
{
    public interface IMatriculaWebService
    {
        Task<ICollection<MatriculaDTO>> GetMatriculas();
    }
}
