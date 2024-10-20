namespace WebServiceIntegration.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public BaseEntity()
        {
        }

        public BaseEntity(int id)
        {
            Id = id;
        }
    }
}
