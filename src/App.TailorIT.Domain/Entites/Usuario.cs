using System;

namespace App.TailorIT.Domain.Entites
{
    public class Usuario
    {
        #region [Properties]
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        //Foreign key
        public int SexoId { get; set; }
        #endregion [Properties]

        #region [Relationship EF]
        public virtual Sexo Sexo { get; set; }
        #endregion [Relationship EF]
    }
}
