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
        var alunoProcess = new AlunoProcess("alunos", "alunos.xml", new AlunoSource(), new AlunoTransform(), new AlunoSink());
        await alunoProcess.Execute();

        var disciplinaProcess = new DisciplinaProcess("disciplinas", "disciplinas.xml", new DisciplinaSource(), new DisciplinaTransform(), new DisciplinaSink());
        await disciplinaProcess.Execute();

        var matriculaProcess = new MatriculaProcess("matriculas", "matriculas.xml", new MatriculaSource(), new MatriculaTransform(), new MatriculaSink());
        await matriculaProcess.Execute();
    }
}