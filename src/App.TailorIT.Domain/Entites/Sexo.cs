using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.TailorIT.Domain.Entites
{
    public class Sexo
    {
        #region [Properties]

        public int SexoId { get; set; }

        public string Descricao { get; set; }
        #endregion [Properties]

        public Usuario Usuario { get; set; }
    }
}
