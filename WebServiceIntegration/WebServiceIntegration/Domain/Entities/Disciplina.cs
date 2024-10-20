namespace WebServiceIntegration.Domain.Entities
{
    [Serializable]
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
