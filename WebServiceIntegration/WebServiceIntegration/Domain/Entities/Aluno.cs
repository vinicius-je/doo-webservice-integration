using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceIntegration.Domain.Entities
{
    [Serializable]
    public class Aluno : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;

        public Aluno()
        {
        }

        public Aluno(int id, string nome, string endereco) : base(id)
        {
            Nome = nome;
            Endereco = endereco;
        }
    }
}
