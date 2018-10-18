using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros

{
    public class Usuario
    {
        [Display(Name = "Código")]
        public int UsuarioID { get; set; }

        [Display(Name = "Nome")]
        public string NomeUsuario { get; set; }

        [Display(Name = "Apelido")]
        public string ApelidoUsuario { get; set; }

        [Display(Name = "Senha")]
        public string SenhaUsuario { get; set; }

        [Display(Name = "Confirmar Senha")]
        public string ConfirmarSenhaUsuario { get; set; }

        [Display(Name = "E-mail")]
        public string EmailUsuario { get; set; }

        [Display(Name = "Telefone")]
        public string TelefoneUsuario { get; set; }
    }
}