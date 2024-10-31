using WebServiceIntegration.Domain.DTOs;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Process.Interfaces;
using WebServiceIntegration.Sink.Impl;
using WebServiceIntegration.Source.Interfaces;
using WebServiceIntegration.Transform.Interfaces;

namespace WebServiceIntegration.Process.Impl
{
    public class MatriculaProcess : BaseProcess<Matricula, MatriculaDTO>, IMatriculaProcess
    {
        public MatriculaProcess(string endpoint, string filename, ISource<MatriculaDTO> source, ITransform<Matricula, MatriculaDTO> transform, ISink<Matricula> sink) : base(endpoint, filename, source, transform, sink)
        {
        }
    }
}
