namespace WebServiceIntegration.Domain.DTOs
{
    public record MatriculaDTO : BaseDTO
    {
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }
    }
}
