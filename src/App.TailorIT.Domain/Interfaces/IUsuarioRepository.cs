using App.TailorIT.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.TailorIT.Domain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<List<Usuario>> GetUsuarios();
        Task<List<Usuario>> GetUsuariosFilters(string nome, int? sexoId);
    }
}
