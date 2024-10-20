using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceIntegration.Domain.Entities
{
    public class Disciplina : BaseEntity
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        public Disciplina() { }
        public Disciplina(int id, string nome, string descricao) : base(id)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}
