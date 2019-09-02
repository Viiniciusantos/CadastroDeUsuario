using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.TailorIT.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {
            Sexos = new List<SexoViewModel>();
        }

        #region [Properties]
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [EmailAddress(ErrorMessage = "Digite um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [StringLength(30, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Senha { get; set; }

        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DisplayName("Sexo")]
        public int SexoId { get; set; }
        #endregion [Properties]

        #region [Relationship EF]
        public virtual SexoViewModel Sexo { get; set; }
        public virtual List<SexoViewModel> Sexos { get; set; }
        #endregion [Relationship EF]
    }
}
