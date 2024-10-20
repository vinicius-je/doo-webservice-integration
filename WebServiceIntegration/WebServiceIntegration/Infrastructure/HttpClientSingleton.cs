namespace WebServiceIntegration.Infrastructure
{
    public class HttpClientSingleton
    {
        private static string BASE_URL = "http://localhost:3000";
        private static Lazy<HttpClient> _instance = new Lazy<HttpClient>(() => new HttpClient { BaseAddress = new Uri(BASE_URL) });

        // Construtor privado para evitar a criação de instâncias fora da classe
        private HttpClientSingleton() { }

        // Propriedade para acessar a instância Singleton do HttpClient
        public static HttpClient Instance => _instance.Value;
    }
}
