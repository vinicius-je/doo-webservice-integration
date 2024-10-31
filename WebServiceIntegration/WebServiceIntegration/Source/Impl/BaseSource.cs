using Newtonsoft.Json;
using WebServiceIntegration.Domain.DTOs;
using WebServiceIntegration.Infrastructure;
using WebServiceIntegration.Source.Interfaces;

namespace WebServiceIntegration.Source.Impl
{
    public class BaseSource<T> : ISource<T> where T : BaseDTO
    {
        public async Task<List<T>> Execute(string endpoint)
        {
            // Instancia do HttpClient
            var httpClient = HttpClientSingleton.Instance;
            // Requisicao
            var response = await httpClient.GetAsync(endpoint);

            if (!response.IsSuccessStatusCode)
            {
                return await Task.FromCanceled<List<T>>(new CancellationToken());
            }

            // Converte resposta para string
            var contentString = await response.Content.ReadAsStringAsync();
            // Deserializa o objeto para uma lista de T
            var list = JsonConvert.DeserializeObject<List<T>>(contentString);

            return list;
        }
    }
}
