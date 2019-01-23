using FMP.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.Interfaces.Repositories
{
    public interface ICidadeRepository : IRepository<Cidade>
    {
        IEnumerable<Cidade> ObterporIdEstado(int IdEstado);

    }
}
