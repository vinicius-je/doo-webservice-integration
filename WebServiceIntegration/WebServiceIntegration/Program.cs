using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.Factory.Factories;
using WebServiceIntegration.Application.Service;
using WebServiceIntegration.Application.WebServiceApplication.Services;
using WebServiceIntegration.Core.Application.Interfaces;
using WebServiceIntegration.Core.Application.Services;
using WebServiceIntegration.Infrastructure;

namespace WebServiceIntegration;

class Program
{
    static async Task Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        var alunoWebService = new AlunoWebService(new WebServiceConsume<AlunoDTO>());
        var disciplinaWebService = new DisciplinaWebService(new WebServiceConsume<DisciplinaDTO>());

        var escolaWebService = new EscolaWebService(alunoWebService, disciplinaWebService);
        var service = new Service<AlunoDTO, DisciplinaDTO, MatriculaDTO>(escolaWebService);
        await service.Process();
    }
}