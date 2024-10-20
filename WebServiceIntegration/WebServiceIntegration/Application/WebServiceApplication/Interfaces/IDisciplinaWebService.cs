﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceIntegration.Application.DTOs;

namespace WebServiceIntegration.Application.WebServiceApplication.Interfaces
{
    public interface IDisciplinaWebService 
    {
        Task<ICollection<DisciplinaDTO>> GetDisciplinas();
    }
}