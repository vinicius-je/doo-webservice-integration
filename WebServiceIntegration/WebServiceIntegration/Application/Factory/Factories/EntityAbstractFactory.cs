using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceIntegration.Application.DTOs;
using WebServiceIntegration.Application.Factory.Interfaces;
using WebServiceIntegration.Domain.Entities;
using WebServiceIntegration.Domain.Shared;

namespace WebServiceIntegration.Application.Factory.Factories
{
    public class EntityAbstractFactory<TRequest, TResponse> : IEntityAbstractFactory<TRequest, TResponse>
        where TRequest : BaseDTO
        where TResponse : BaseEntity, new()
    {
        public TResponse CreateEntity(TRequest request)
        {
            return EntidadeShared.InstanciarEntidade<TResponse, TRequest>(request);
        }
    }
}
