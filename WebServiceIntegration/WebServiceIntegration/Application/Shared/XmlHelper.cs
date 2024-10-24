using System.Xml.Serialization;

namespace WebServiceIntegration.Application.Shared
{
    public class XmlHelper
    {
        public void GerarXml<T>(List<T> listaObjetos, string caminhoArquivo)
        {
            // Criar um XmlSerializer para a lista do tipo T
            var serializer = new XmlSerializer(typeof(List<T>));

            // Abrir ou criar o arquivo XML
            using (var writer = new StreamWriter(caminhoArquivo))
            {
                // Serializar a lista de objetos no arquivo
                serializer.Serialize(writer, listaObjetos);
            }
        }
    }
}
