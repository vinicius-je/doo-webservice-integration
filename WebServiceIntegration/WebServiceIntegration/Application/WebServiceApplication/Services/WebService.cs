using Newtonsoft.Json;
using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.WebServiceApplication.Interfaces;
using WebServiceIntegration.Infrastructure;

namespace WebServiceIntegration.Application.WebServiceApplication.Services
{
    public class WebService<T> : IWebService<T> where T : BaseDTO
    {
        public async Task<ICollection<T>> GetEntity(string endpoint)
        {
            var response = await HttpClientSingleton.Instance.GetAsync(endpoint);

            if (!response.IsSuccessStatusCode)
            {
                return await Task.FromCanceled<ICollection<T>>(new CancellationToken());
            }

            var contentString = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<ICollection<T>>(contentString);

            return list;
        }
    }
}
