using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Domain.Entities;

namespace WebServiceIntegration.Domain.Shared
{
    public static class EntidadeShared
    {
        public static T InstanciarEntidade<T, R>(R dto)
            where T : BaseEntity, new()
            where R : BaseDTO
        {
            var entidade = new T();

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
