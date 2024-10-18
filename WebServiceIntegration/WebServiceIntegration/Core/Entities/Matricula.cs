using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceIntegration.Core.Entities
{
    public class Matricula : BaseEntity
    {
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }

        public Matricula(int alunoId, int disciplinaId)
        {
            AlunoId = alunoId;
            DisciplinaId = disciplinaId;
        }
    }
}
