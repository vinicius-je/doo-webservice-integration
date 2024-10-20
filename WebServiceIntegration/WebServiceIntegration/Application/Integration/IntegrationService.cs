using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.Integration.Interfaces;
using WebServiceIntegration.Application.Shared;
using WebServiceIntegration.Core.Application.Interfaces;
using WebServiceIntegration.Domain.Entities;

namespace WebServiceIntegration.Application.Integration
{
    public class IntegrationService : IIntegrationService
    {
        private readonly IEscolaWebService<AlunoDTO, DisciplinaDTO, MatriculaDTO> _escolaWebService;

        public IntegrationService(IEscolaWebService<AlunoDTO, DisciplinaDTO, MatriculaDTO> escolaWebService)
        {
            _escolaWebService = escolaWebService;
        }

        public async Task Process()
        {
            // Consumir websevice
            var alunosDTO = await _escolaWebService.GetAlunos();
            var disciplinasDTO = await _escolaWebService.GetDisciplinas();
            var matriculasDTO = await _escolaWebService.GetMatriculas();
            // Gerar entidades
            List<Aluno> alunos = EntidadeHelper<Aluno, AlunoDTO>.criarEntidadeViaFactory(alunosDTO);
            List<Disciplina> disciplinas = EntidadeHelper<Disciplina, DisciplinaDTO>.criarEntidadeViaFactory(disciplinasDTO);
            List<Matricula> matriculas = EntidadeHelper<Matricula, MatriculaDTO>.criarEntidadeViaFactory(matriculasDTO);
            // Gerar XMLs
            XmlHelper.GerarXml<Aluno>(alunos, "./alunos.xml");
            XmlHelper.GerarXml<Disciplina>(disciplinas, "./disciplinas.xml");
            XmlHelper.GerarXml<Matricula>(matriculas, "./matriculas.xml");

        }
    }
}
