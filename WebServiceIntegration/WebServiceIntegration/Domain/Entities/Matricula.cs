using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceIntegration.Domain.Entities
{
    public class Matricula : BaseEntity
    {
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }

        public Matricula(int id, int alunoId, int disciplinaId) : base(id)
        {
            AlunoId = alunoId;
            DisciplinaId = disciplinaId;
        }
    }
}
