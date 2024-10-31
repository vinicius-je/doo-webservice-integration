using WebServiceIntegration.Domain.DTOs;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Process.Interfaces;
using WebServiceIntegration.Sink.Impl;
using WebServiceIntegration.Source.Interfaces;
using WebServiceIntegration.Transform.Interfaces;

namespace WebServiceIntegration.Process.Impl
{
    public class BaseProcess<Entity, Dto> : IProcess
        where Entity : BaseEntity
        where Dto : BaseDTO
    {
        private string _endpoint = string.Empty;
        private string _filename = string.Empty;
        private readonly ISource<Dto> _source;
        private readonly ITransform<Entity, Dto> _transform;
        private readonly ISink<Entity> _sink;

        public BaseProcess(
            string endpoint,
            string filename,
            ISource<Dto> source,
            ITransform<Entity, Dto> transform,
            ISink<Entity> sink)
        {
            _endpoint = endpoint;
            _filename = filename;
            _source = source;
            _transform = transform;
            _sink = sink;
        }

        public async Task Execute()
        {
            var dtoList = await _source.Execute(_endpoint);
            var entityList = _transform.Execute(dtoList);
            var result = _sink.Execute(entityList, _filename);
            Console.WriteLine($"Processo finalizado - arquivo: {_filename} gerado com sucesso!");
        }
    }
}
