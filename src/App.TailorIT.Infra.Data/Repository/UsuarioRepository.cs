using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.TailorIT.Domain.Entites;
using App.TailorIT.Domain.Interfaces;
using App.TailorIT.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace App.TailorIT.Infra.Data.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(TailorITContext context) : base(context) { }

        public async Task<List<Usuario>> GetUsuarios()
        {
            return await Db.Usuarios.AsNoTracking().Include(u => u.Sexo).ToListAsync();
        }

        public async Task<List<Usuario>> GetUsuariosFilters(string nome, int? sexoId)
        {
            var nomebool = !string.IsNullOrEmpty(nome) ? true : false;
            var sexobool = !string.IsNullOrEmpty(sexoId.ToString()) ? true : false;

            if (nomebool && !sexobool)
            {
                return await Db.Usuarios.AsNoTracking().Where(u => EF.Functions.Like(u.Nome, $"%{nome}%")).Include(s => s.Sexo).ToListAsync();
            }
            else if (!nomebool && sexobool)
            {
                return await Db.Usuarios.AsNoTracking().Where(s => s.SexoId == sexoId).Include(s => s.Sexo).ToListAsync();
            }

            return await Db.Usuarios.AsNoTracking().Where(u => EF.Functions.Like(u.Nome, $"%{nome}%") && u.SexoId == sexoId).Include(s => s.Sexo).ToListAsync();
        }
    }
}
