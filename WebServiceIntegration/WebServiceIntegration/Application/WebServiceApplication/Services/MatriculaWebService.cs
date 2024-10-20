using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.WebServiceApplication.Interfaces;

namespace WebServiceIntegration.Application.WebServiceApplication.Services
{
    public class MatriculaWebService : IMatriculaWebService
    {
        private readonly IWebService<MatriculaDTO> _webService;

        public MatriculaWebService(IWebService<MatriculaDTO> webService)
        {
            _webService = webService;
        }

        public async Task<ICollection<MatriculaDTO>> GetMatriculas()
        {
            return await _webService.GetEntity("matriculas");
        }
    }
}
