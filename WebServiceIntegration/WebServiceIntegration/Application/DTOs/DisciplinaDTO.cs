namespace WebServiceIntegration.Application.DTOs
{
    public record DisciplinaDTO : BaseDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}
