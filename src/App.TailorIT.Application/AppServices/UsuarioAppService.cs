using App.TailorIT.Application.Interfaces;
using App.TailorIT.Application.ViewModels;
using App.TailorIT.Domain.Entites;
using App.TailorIT.Domain.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.TailorIT.Application.AppServices
{
    public class UsuarioAppService : IUsuarioAppService
    {
        #region [Constructor]
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioAppService(IUsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }
        #endregion [Constructor]

        public async Task Add(UsuarioViewModel usuario)
        {
            Usuario UsuarioEntity = _mapper.Map<Usuario>(usuario);
            await _usuarioService.Add(UsuarioEntity);
        }

        public async Task Delete(int id)
        {
            await _usuarioService.Delete(id);
        }

        public async Task<List<UsuarioViewModel>> GetAll()
        {
            return _mapper.Map<List<UsuarioViewModel>>(await _usuarioService.GetAll());
        }

        public async Task<UsuarioViewModel> GetForId(int id)
        {
            return _mapper.Map<UsuarioViewModel>(await _usuarioService.GetForId(id));
        }

        public async Task Update(UsuarioViewModel usuario)
        {
            Usuario usuarioEntity = _mapper.Map<Usuario>(usuario);
            await _usuarioService.Update(usuarioEntity);
        }

        public async Task<List<UsuarioViewModel>> GetUserFilters(string nome, int? sexoId)
        {
            return _mapper.Map<List<UsuarioViewModel>>(await _usuarioService.GetUserFilters(nome, sexoId));
        }
    }
}
