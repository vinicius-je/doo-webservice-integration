using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceIntegration.Core.Entities
{
    public class Aluno : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;

        public Aluno(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }
    }
}
