using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.TailorIT.Application.ViewModels
{
    public class SexoViewModel
    {
        #region [Properties]
        [Key]
        public int SexoId { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        #endregion [Properties]
    }
}