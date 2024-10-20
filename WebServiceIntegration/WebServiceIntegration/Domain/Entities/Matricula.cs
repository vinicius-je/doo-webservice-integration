namespace WebServiceIntegration.Domain.Entities
{
    [Serializable]
    public class Matricula : BaseEntity
    {
        public int AlunoId { get; set; }
        public int DisciplinaId { get; set; }

        public Matricula() { }

        public Matricula(int id, int alunoId, int disciplinaId) : base(id)
        {
            AlunoId = alunoId;
            DisciplinaId = disciplinaId;
        }
    }
}
