using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.WebServiceApplication.Interfaces;
using WebServiceIntegration.Core.Application.Interfaces;
using WebServiceIntegration.Domain.Entities;

namespace WebServiceIntegration.Core.Application.Services
{
    public class EscolaWebService : IEscolaWebService<AlunoDTO, DisciplinaDTO, MatriculaDTO>  
    {
        private readonly IAlunoWebService _alunosWebService;
        private readonly IDisciplinaWebService _disciplinasWebService;

        public EscolaWebService(IAlunoWebService alunosWebService, IDisciplinaWebService disciplinasWebService)
        {
            _alunosWebService = alunosWebService;
            _disciplinasWebService = disciplinasWebService;
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
            return await Task.FromResult(new List<MatriculaDTO>());
        }
    }
}
