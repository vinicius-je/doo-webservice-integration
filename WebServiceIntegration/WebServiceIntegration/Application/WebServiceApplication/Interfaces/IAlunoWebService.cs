using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceIntegration.Application.DTOs;

namespace WebServiceIntegration.Application.WebServiceApplication.Interfaces
{
    public interface IAlunoWebService
    {
        Task<ICollection<AlunoDTO>> GetAlunos();
    }
}
