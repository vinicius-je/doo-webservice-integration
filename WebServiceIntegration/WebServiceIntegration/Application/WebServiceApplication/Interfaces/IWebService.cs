using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceIntegration.Application.DTOs;

namespace WebServiceIntegration.Application.WebServiceApplication.Interfaces
{
    public interface IWebService<T> where T : BaseDTO
    {
        Task<ICollection<T>> GetEntity(string endpoint);
    }
}
