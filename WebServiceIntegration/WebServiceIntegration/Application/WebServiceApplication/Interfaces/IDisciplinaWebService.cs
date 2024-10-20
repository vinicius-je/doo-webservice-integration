using WebServiceIntegration.Application.DTOs;

namespace WebServiceIntegration.Application.WebServiceApplication.Interfaces
{
    public interface IDisciplinaWebService
    {
        Task<ICollection<DisciplinaDTO>> GetDisciplinas();
    }
}
