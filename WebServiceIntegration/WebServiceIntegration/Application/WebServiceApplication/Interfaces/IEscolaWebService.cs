using WebServiceIntegration.Application.DTOs;

namespace WebServiceIntegration.Core.Application.Interfaces
{
    public interface IEscolaWebService<A, D, M>
        where A : BaseDTO
        where D : BaseDTO
        where M : BaseDTO
    {
        Task<ICollection<A>> GetAlunos();
        Task<ICollection<D>> GetDisciplinas();
        Task<ICollection<M>> GetMatriculas();
    }
}
