using App.TailorIT.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.TailorIT.Application.Interfaces
{
    public interface ISexoAppService
    {
        Task<SexoViewModel> GetForId(int id);
        Task<List<SexoViewModel>> GetAll();
    }
}
