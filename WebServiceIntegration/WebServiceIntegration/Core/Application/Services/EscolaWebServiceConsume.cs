using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WebServiceIntegration.Core.Application.Interfaces;
using WebServiceIntegration.Core.Entities;

namespace WebServiceIntegration.Core.Application.Services
{
    public class EscolaWebServiceConsume : IEscolaWebServiceConsume
    {
        private readonly HttpClient _httpClient;
        private readonly static string URL = "http://localhost:3000";

        public EscolaWebServiceConsume(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(URL);
        }

        public async Task<ICollection<Aluno>> GetAlunos()
        {
            var response = await _httpClient.GetAsync("alunos");

            if (!response.IsSuccessStatusCode)
            {
                // error
            }

            var alunos = JsonConvert.DeserializeObject<ICollection<Aluno>>(await response.Content.ReadAsStringAsync());

            return alunos;
        }

        public async Task<ICollection<Disciplina>> GetDisciplinas()
        {
            var response = await _httpClient.GetAsync("/disciplinas");

            if (!response.IsSuccessStatusCode)
            {
                // error
            }

            var disciplinas = JsonConvert.DeserializeObject<ICollection<Disciplina>>(await response.Content.ReadAsStringAsync());

            return disciplinas;
        }

        public async Task<ICollection<Matricula>> GetMatriculas()
        {
            var response = await _httpClient.GetAsync("/matriculas");

            if (!response.IsSuccessStatusCode)
            {
                // error
            }

            var matriculas = JsonConvert.DeserializeObject<ICollection<Matricula>>(await response.Content.ReadAsStringAsync());

            return matriculas;
        }
    }
}
