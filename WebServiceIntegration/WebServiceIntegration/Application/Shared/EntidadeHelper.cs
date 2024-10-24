using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.Factory.Factories;
using WebServiceIntegration.Domain.Entities;

namespace WebServiceIntegration.Application.Shared
{
    public class EntidadeHelper<E, D>
        where E : BaseEntity, new()
        where D : BaseDTO
    {
        public List<E> criarEntidadeViaFactory(ICollection<D> listaDTO)
        {
            List<E> lista = [];
            var entidadeFactory = new EntityAbstractFactory<D, E>();

            foreach (var dto in listaDTO)
            {
                lista.Add(entidadeFactory.CreateEntity(dto));
            }

            return lista;
        }
    }
}
