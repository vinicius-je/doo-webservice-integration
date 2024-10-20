using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.WebServiceApplication.Interfaces;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Infrastructure;

namespace WebServiceIntegration.Application.WebServiceApplication.Services
{
    public class WebServiceConsume<T> : IWebService<T> where T : BaseDTO
    {
        public async Task<ICollection<T>> GetEntity(string endpoint)
        {
            var response = await HttpClientSingleton.Instance.GetAsync(endpoint); 

            if (!response.IsSuccessStatusCode)
            {
                // error
            }

            var contentString = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<ICollection<T>>(contentString);

            return list;
        }
    }
}
