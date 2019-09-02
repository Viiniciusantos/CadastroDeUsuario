using App.TailorIT.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.TailorIT.Application.Interfaces
{
    public interface IUsuarioAppService
    {
        Task Add(UsuarioViewModel usuario);
        Task<UsuarioViewModel> GetForId(int id);
        Task<List<UsuarioViewModel>> GetAll();
        Task Update(UsuarioViewModel usuario);
        Task Delete(int id);
        Task<List<UsuarioViewModel>> GetUserFilters(string nome, int? sexoId);
    }
}
