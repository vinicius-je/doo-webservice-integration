namespace WebServiceIntegration.Application.DTOs
{
    public record AlunoDTO : BaseDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
    }
}
