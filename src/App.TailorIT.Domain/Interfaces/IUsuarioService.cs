using App.TailorIT.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.TailorIT.Domain.Interfaces
{
    public interface IUsuarioService : IDisposable
    {
        Task Add(Usuario usuario);
        Task<Usuario> GetForId(int id);
        Task<List<Usuario>> GetAll();
        Task Update(Usuario usuario);
        Task Delete(int id);
        Task<List<Usuario>> GetUserFilters(string nome, int? sexoId);
    }
}
