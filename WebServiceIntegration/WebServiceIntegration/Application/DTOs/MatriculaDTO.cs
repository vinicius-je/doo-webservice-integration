using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceIntegration.Application.DTOs
{
    public record MatriculaDTO : BaseDTO
    {
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }
    }
}
