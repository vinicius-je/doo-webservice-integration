﻿using WebServiceIntegration.Application.DTOs;

namespace WebServiceIntegration.Application.WebServiceApplication.Interfaces
{
    public interface IAlunoWebService
    {
        Task<ICollection<AlunoDTO>> GetAlunos();
    }
}
