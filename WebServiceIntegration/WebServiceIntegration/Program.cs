using WebServiceIntegration.Core.Application.Interfaces;
using WebServiceIntegration.Core.Application.Services;

namespace WebServiceIntegration;

class Program
{
    static async Task Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
        await GetData();
    }

    static async Task GetData()
    {
        IEscolaWebServiceConsume webServiceConsume = new EscolaWebServiceConsume(new HttpClient());

        var alunos = await webServiceConsume.GetAlunos();
        var disciplinas = await webServiceConsume.GetDisciplinas();
        var matriculas = await webServiceConsume.GetMatriculas();
    }
}