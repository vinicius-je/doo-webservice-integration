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
        /// <summary>
        /// 1. Consome o WebService
        /// 2. Converte as entidades
        /// 3. Gera os XMLs
        /// </summary>
        /// <returns></returns>
        public async Task Process()
        {
            // Consumir websevice
            var alunosDTO = await _escolaWebService.GetAlunos();
            var disciplinasDTO = await _escolaWebService.GetDisciplinas();
            var matriculasDTO = await _escolaWebService.GetMatriculas();
            // Gerar entidades
            List<Aluno> alunos = new EntidadeHelper<Aluno, AlunoDTO>().criarEntidadeViaFactory(alunosDTO);
            List<Disciplina> disciplinas = new EntidadeHelper<Disciplina, DisciplinaDTO>().criarEntidadeViaFactory(disciplinasDTO);
            List<Matricula> matriculas = new EntidadeHelper<Matricula, MatriculaDTO>().criarEntidadeViaFactory(matriculasDTO);
            // Gerar XMLs
            var xml = new XmlHelper();
            xml.GerarXml<Aluno>(alunos, "./alunos.xml");
            xml.GerarXml<Disciplina>(disciplinas, "./disciplinas.xml");
            xml.GerarXml<Matricula>(matriculas, "./matriculas.xml");
        }
    }
}
