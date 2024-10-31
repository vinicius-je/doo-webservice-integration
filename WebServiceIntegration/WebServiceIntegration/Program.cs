using WebServiceIntegration.Process.Impl;
using WebServiceIntegration.Sink.Interfaces;
using WebServiceIntegration.Source.Impl;
using WebServiceIntegration.Transform.Impl;

namespace WebServiceIntegration;

class Program
{
    static async Task Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, FUCKIN World!");

        var alunoProcess = new AlunoProcess("alunos", "alunos.xml", new AlunoSource(), new AlunoTransform(), new AlunoSink());
        await alunoProcess.Execute();
    }
}