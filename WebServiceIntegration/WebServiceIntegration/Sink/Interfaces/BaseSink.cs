using System.Xml.Serialization;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Sink.Impl;

namespace WebServiceIntegration.Sink.Interfaces
{
    public class BaseSink<Entity> : ISink<Entity> where Entity : BaseEntity
    {
        public Task Execute(List<Entity> list, string filename)
        {
            // Criar um XmlSerializer para a lista do tipo T
            var serializer = new XmlSerializer(typeof(List<Entity>));

            // Abrir ou criar o arquivo XML
            using (var writer = new StreamWriter(filename))
            {
                // Serializar a lista de objetos no arquivo
                serializer.Serialize(writer, list);
            }

            return Task.CompletedTask;
        }
    }
}
