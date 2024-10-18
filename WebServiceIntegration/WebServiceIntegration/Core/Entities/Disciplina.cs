using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceIntegration.Core.Entities
{
    public class Disciplina : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        public Disciplina(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
