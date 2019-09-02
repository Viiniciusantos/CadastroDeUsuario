using App.TailorIT.Domain.Entites;
using App.TailorIT.Domain.Interfaces;
using App.TailorIT.Infra.Data.Context;

namespace App.TailorIT.Infra.Data.Repository
{
    public class SexoRepository : Repository<Sexo>, ISexoRepository
    {
        public SexoRepository(TailorITContext context) : base(context) { }
    }
}
