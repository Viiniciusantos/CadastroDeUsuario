using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.TailorIT.Application.ViewModels;
using App.TailorIT.Application.Interfaces;

namespace App.TailorIT.UI.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioAppService _usuarioAppService;
        private readonly ISexoAppService _sexoAppService;

        public UsuariosController(IUsuarioAppService usuarioAppService, ISexoAppService sexoAppService)
        {
            _usuarioAppService = usuarioAppService;
            _sexoAppService = sexoAppService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await GetUsers();
            return View(result);
        }

        public PartialViewResult _Index()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<PartialViewResult> Filters(string nome, string sexoId)
        {
            if(string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(sexoId))
                return PartialView("_Index", await _usuarioAppService.GetAll());

            if (!string.IsNullOrEmpty(sexoId)){
                int sexoIdNumber = Convert.ToInt32(sexoId);

                return PartialView("_Index", await _usuarioAppService.GetUserFilters(nome, sexoIdNumber));
            }
                
            return PartialView("_Index", await _usuarioAppService.GetUserFilters(nome, null));
        }

        public async Task<IActionResult> Create()
        {
            UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Sexos = await _sexoAppService.GetAll();

            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Create(UsuarioViewModel usuarioViewModel)
        {
            if (!ModelState.IsValid)
                return false;

            await _usuarioAppService.Add(usuarioViewModel);

            return true;
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
                return NotFound();

            var usuarioViewModel = await _usuarioAppService.GetForId(id);
            if (usuarioViewModel == null)
                return NotFound();

            usuarioViewModel.Sexos = await _sexoAppService.GetAll();

            return View(usuarioViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UsuarioViewModel usuarioViewModel)
        {
            if (id != usuarioViewModel.UsuarioId)
                return NotFound();

            if (!ModelState.IsValid)
                return View(usuarioViewModel);

            await _usuarioAppService.Update(usuarioViewModel);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<bool> DeleteConfirmed(int id)
        {
            var usuario = await _usuarioAppService.GetForId(id);
            if (usuario == null)
                return false;

            await _usuarioAppService.Delete(id);
            return true;
        }

        public async Task<IEnumerable<UsuarioViewModel>> GetUsers()
        {
            List<UsuarioViewModel> usuarios = await _usuarioAppService.GetAll();
            if (usuarios.Count > 0)
            {
                usuarios[0].Sexos = await _sexoAppService.GetAll();
            }
            else
            {
                UsuarioViewModel usuario = new UsuarioViewModel();
                usuario.Sexos = await _sexoAppService.GetAll();
                usuarios.Add(usuario);
            }


            return usuarios.AsEnumerable();
        }
    }
}
