using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.Factory.Factories;
using WebServiceIntegration.Application.Factory.Interfaces;
using WebServiceIntegration.Core.Application.Interfaces;
using WebServiceIntegration.Core.Application.Services;
using WebServiceIntegration.Domain.Entities;

namespace WebServiceIntegration.Application.Service
{
    public class Service<TAluno, TDisciplina, TMatricula>
        where TAluno : BaseDTO
        where TDisciplina : BaseDTO
        where TMatricula : BaseDTO
    {
        //private readonly IEntityAbstractFactory<BaseDTO, BaseEntity> _entityAbstractFactory;
        private readonly IEscolaWebService<AlunoDTO, DisciplinaDTO, MatriculaDTO> _escolaWebService;

        public Service(
            //IEntityAbstractFactory<BaseDTO, BaseEntity> entityAbstractFactory,
            IEscolaWebService<AlunoDTO, DisciplinaDTO, MatriculaDTO> escolaWebService)
        {
            _escolaWebService = escolaWebService;
            //_entityAbstractFactory = entityAbstractFactory;
        }

        public async Task Process()
        {
            var alunosDTO = await _escolaWebService.GetAlunos();
            var disciplinasDTO = await _escolaWebService.GetDisciplinas();
            //var matriculasDTO = await _escolaWebService.GetMatriculas();

            ICollection<Aluno> alunos = []; 
            ICollection<Disciplina> disciplinas = [];

            var alunoFactory = new EntityAbstractFactory<AlunoDTO, Aluno>();
            var disciplinaFactory = new EntityAbstractFactory<DisciplinaDTO, Disciplina>();

            foreach (var aluno in alunosDTO)
            {
                alunos.Add(alunoFactory.CreateEntity(aluno));
            }

            foreach (var disciplina in disciplinasDTO)
            {
                disciplinas.Add(disciplinaFactory.CreateEntity(disciplina));
            }
            
            var alunoSerializer = new XmlSerializer(typeof(List<Aluno>));
            using (var writer = new StreamWriter("alunos.xml"))
            {
                alunoSerializer.Serialize(writer, alunos);
            }
            Console.WriteLine($"Arquivo XML gerado com sucesso em");
        }
    }
}
