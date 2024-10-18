using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceIntegration.Core.Entities;

namespace WebServiceIntegration.Core.Application.Interfaces
{
    public interface IEscolaWebServiceConsume
    {
        Task<ICollection<Aluno>> GetAlunos();
        Task<ICollection<Disciplina>> GetDisciplinas();
        Task<ICollection<Matricula>> GetMatriculas();
    }
}
