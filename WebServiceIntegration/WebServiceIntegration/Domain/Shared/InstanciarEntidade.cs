using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Domain.Entities;

namespace WebServiceIntegration.Domain.Shared
{
    public class EntidadeShared
    {
        /// <summary>
        /// Instacia qualquer entidade dado um DTO com atributos compatível
        /// </summary>
        /// <typeparam name="Entity">Entidade</typeparam>
        /// <typeparam name="Dto">DTO</typeparam>
        /// <param name="dto"></param>
        /// <returns></returns>
        public Entity InstanciarEntidade<Entity, Dto>(Dto dto)
            where Entity : BaseEntity, new()
            where Dto : BaseDTO
        {
            var entidade = new Entity();

            // Obtem as propriedades da entidade e do DTO
            var propriedadesEntidade = entidade.GetType().GetProperties();
            var propriedadesDTO = dto.GetType().GetProperties();

            foreach (var prop in propriedadesDTO)
            {
                // Busca uma propriedade na entidade com o mesmo nome e tipo compatíve
                var propEntidade = propriedadesEntidade.FirstOrDefault(x => x.Name == prop.Name);

                if (propEntidade != null)
                {
                    propEntidade.SetValue(entidade, prop.GetValue(dto));
                }
            }

            return entidade;
        }
    }
}
