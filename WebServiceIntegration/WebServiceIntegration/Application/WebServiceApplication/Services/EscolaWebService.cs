using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.WebServiceApplication.Interfaces;
using WebServiceIntegration.Core.Application.Interfaces;

namespace WebServiceIntegration.Core.Application.Services
{
    public class EscolaWebService : IEscolaWebService<AlunoDTO, DisciplinaDTO, MatriculaDTO>
    {
        private readonly IAlunoWebService _alunosWebService;
        private readonly IDisciplinaWebService _disciplinasWebService;
        private readonly IMatriculaWebService _matriculaWebService;

        public EscolaWebService(
            IAlunoWebService alunosWebService,
            IDisciplinaWebService disciplinasWebService,
            IMatriculaWebService matriculaWebService)
        {
            _alunosWebService = alunosWebService;
            _disciplinasWebService = disciplinasWebService;
            _matriculaWebService = matriculaWebService;
        }

        public async Task<ICollection<AlunoDTO>> GetAlunos()
        {
            return await _alunosWebService.GetAlunos();
        }

        public async Task<ICollection<DisciplinaDTO>> GetDisciplinas()
        {
            return await _disciplinasWebService.GetDisciplinas();
        }

        public async Task<ICollection<MatriculaDTO>> GetMatriculas()
        {
            return await _matriculaWebService.GetMatriculas();
        }
    }
}
