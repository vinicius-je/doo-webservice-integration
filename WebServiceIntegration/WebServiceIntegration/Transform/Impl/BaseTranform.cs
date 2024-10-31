using WebServiceIntegration.Domain.DTOs;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Transform.Factory.Factories;
using WebServiceIntegration.Transform.Factory.Interfaces;
using WebServiceIntegration.Transform.Interfaces;

namespace WebServiceIntegration.Transform.Impl
{
    public class BaseTranform<Entity, Dto> : ITransform<Entity, Dto>
        where Entity : BaseEntity, new()
        where Dto : BaseDTO
    {
        private readonly IEntityAbstractFactory<Dto, Entity> _factory;

        public BaseTranform()
        {
            _factory = new EntityAbstractFactory<Dto, Entity>();
        }

        public List<Entity> Execute(List<Dto> list)
        {
            List<Entity> baseList = [];

            foreach (var dto in list)
            {
                baseList.Add(_factory.CreateEntity(dto));
            }

            return baseList;
        }
    }
}
