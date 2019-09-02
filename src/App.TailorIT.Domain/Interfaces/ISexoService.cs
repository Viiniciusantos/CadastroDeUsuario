using App.TailorIT.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.TailorIT.Domain.Interfaces
{
    public interface ISexoService : IDisposable
    {
        Task<Sexo> GetForId(int id);
        Task<List<Sexo>> GetAll();
    }
}
