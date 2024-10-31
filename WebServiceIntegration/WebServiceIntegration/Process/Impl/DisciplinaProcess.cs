using WebServiceIntegration.Domain.DTOs;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Process.Interfaces;
using WebServiceIntegration.Sink.Impl;
using WebServiceIntegration.Source.Interfaces;
using WebServiceIntegration.Transform.Interfaces;

namespace WebServiceIntegration.Process.Impl
{
    public class DisciplinaProcess : BaseProcess<Disciplina, DisciplinaDTO>, IDisciplinaProcess
    {
        public DisciplinaProcess(string endpoint, string filename, ISource<DisciplinaDTO> source, ITransform<Disciplina, DisciplinaDTO> transform, ISink<Disciplina> sink) : base(endpoint, filename, source, transform, sink)
        {
        }
    }
}
