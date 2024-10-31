using WebServiceIntegration.Domain.DTOs;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Process.Interfaces;
using WebServiceIntegration.Sink.Impl;
using WebServiceIntegration.Source.Interfaces;
using WebServiceIntegration.Transform.Interfaces;

namespace WebServiceIntegration.Process.Impl
{
    public class AlunoProcess : BaseProcess<Aluno, AlunoDTO>, IAlunoProcess
    {
        public AlunoProcess(string endpoint, string filename, ISource<AlunoDTO> source, ITransform<Aluno, AlunoDTO> transform, ISink<Aluno> sink) : base(endpoint, filename, source, transform, sink)
        {
        }
    }
}
