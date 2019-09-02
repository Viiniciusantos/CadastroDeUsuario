using App.TailorIT.Application.Interfaces;
using App.TailorIT.Application.ViewModels;
using App.TailorIT.Domain.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.TailorIT.Application.AppServices
{
    public class SexoAppService : ISexoAppService
    {
        #region [Constructor]
        private readonly ISexoService _sexoService;
        private readonly IMapper _mapper;

        public SexoAppService(ISexoService sexoService, IMapper mapper)
        {
            _sexoService = sexoService;
            _mapper = mapper;
        }
        #endregion [Constructor]

        public async Task<List<SexoViewModel>> GetAll()
        {
            return _mapper.Map<List<SexoViewModel>>(await _sexoService.GetAll());
        }

        public async Task<SexoViewModel> GetForId(int id)
        {
            return _mapper.Map<SexoViewModel>(await _sexoService.GetForId(id));
        }
    }
}
