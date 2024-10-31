using WebServiceIntegration.Domain.DTOs;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Process.Interfaces;
using WebServiceIntegration.Sink.Impl;
using WebServiceIntegration.Source.Interfaces;
using WebServiceIntegration.Transform.Factory.Interfaces;

namespace WebServiceIntegration.Process
{
    public class EscolaProcess<Dto, Entity> : IProcess
        where Dto : BaseDTO
        where Entity : BaseEntity
    {
        private readonly ISource<AlunoDTO> _alunoSource;
        private readonly ISource<DisciplinaDTO> _disciplinaSource;
        private readonly ISource<MatriculaDTO> _matriculaSource;

        private readonly IEntityAbstractFactory<Dto, Entity> _factory;

        private readonly ISink<Entity> _sink;

        public Task Execute()
        {
            throw new NotImplementedException();
        }
    }
}
