using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.WebServiceApplication.Interfaces;

namespace WebServiceIntegration.Application.WebServiceApplication.Services
{
    public class DisciplinaWebService : IDisciplinaWebService
    {
        private readonly IWebService<DisciplinaDTO> _webService;

        public DisciplinaWebService(IWebService<DisciplinaDTO> webService)
        {
            _webService = webService;
        }

        public async Task<ICollection<DisciplinaDTO>> GetDisciplinas()
        {
            return await _webService.GetEntity("disciplinas");
        }
    }
}
