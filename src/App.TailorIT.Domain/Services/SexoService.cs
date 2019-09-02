using App.TailorIT.Domain.Entites;
using App.TailorIT.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.TailorIT.Domain.Services
{
    public class SexoService : ISexoService
    {
        private readonly ISexoRepository _sexoRepository;

        public SexoService(ISexoRepository sexoRepository)
        {
            _sexoRepository = sexoRepository;
        }

        public async Task<List<Sexo>> GetAll()
        {
            return await _sexoRepository.GetAll();
        }

        public async Task<Sexo> GetForId(int id)
        {
            return await _sexoRepository.GetForId(id);
        }

        public void Dispose()
        {
            _sexoRepository?.Dispose();
        }
    }
}
