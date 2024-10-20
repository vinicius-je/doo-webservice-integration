using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.Integration;
using WebServiceIntegration.Application.WebServiceApplication.Services;
using WebServiceIntegration.Core.Application.Services;

namespace WebServiceIntegration;

class Program
{
    static async Task Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        var alunoWebService = new AlunoWebService(new WebService<AlunoDTO>());
        var disciplinaWebService = new DisciplinaWebService(new WebService<DisciplinaDTO>());
        var matriculaWebService = new MatriculaWebService(new WebService<MatriculaDTO>());

        var escolaWebService = new EscolaWebService(alunoWebService, disciplinaWebService, matriculaWebService);
        var service = new IntegrationService(escolaWebService);
        await service.Process();
    }
}