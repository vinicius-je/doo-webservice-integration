using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Domain.Entities;

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
