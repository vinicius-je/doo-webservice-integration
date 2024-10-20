using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.WebServiceApplication.Interfaces;

namespace WebServiceIntegration.Application.WebServiceApplication.Services
{
    public class AlunoWebService : IAlunoWebService
    {
        private readonly IWebService<AlunoDTO> _webService;

        public AlunoWebService(IWebService<AlunoDTO> webService)
        {
            _webService = webService;
        } 

        public async Task<ICollection<AlunoDTO>> GetAlunos()
        {
            return await _webService.GetEntity("alunos");
        }
    }
}
