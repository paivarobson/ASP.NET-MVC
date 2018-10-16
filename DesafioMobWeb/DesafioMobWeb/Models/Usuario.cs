namespace DesafioMobWeb.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        public string NomeUsuario { get; set; }

        public string ApelidoUsuario { get; set; }

        private string SenhaUsuario { get; set; }

        private string ConfirmarSenha { get; set; }

        public string EmailUsuario { get; set; }

        public string TelefoneUsuario { get; set; }
    }
}