using WebServiceIntegration.Domain.DTOs;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Transform.Interfaces;

namespace WebServiceIntegration.Transform.Impl
{
    public class AlunoTransform : BaseTranform<Aluno, AlunoDTO>, IAlunoTransform
    {
    }
}
