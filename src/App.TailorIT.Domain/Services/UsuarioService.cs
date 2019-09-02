using App.TailorIT.Domain.Entites;
using App.TailorIT.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.TailorIT.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task Add(Usuario usuario)
        {
            usuario.Ativo = true;
            await _usuarioRepository.Add(usuario);
        }

        public async Task Delete(int id)
        {
            await _usuarioRepository.Delete(id);
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await _usuarioRepository.GetUsuarios();
        }

        public async Task<Usuario> GetForId(int id)
        {
            return await _usuarioRepository.GetForId(id);
        }

        public async Task Update(Usuario usuario)
        {
            await _usuarioRepository.Update(usuario);
        }

        public async Task<List<Usuario>> GetUserFilters(string nome, int? sexoId)
        {
            return await _usuarioRepository.GetUsuariosFilters(nome, sexoId);
        }

        public void Dispose()
        {
            _usuarioRepository?.Dispose();
        }


    }
}
