namespace DesafioMobWeb.Models
{
    public class Usuario
    {
        public int usuarioID { get; set; }

        public string nomeUsuario { get; set; }

        public string apelidoUsuario { get; set; }

        private string senhaUsuario { get; set; }

        private string confirmarSenha { get; set; }

        public string emailUsuario { get; set; }

        public string telefoneUsuario { get; set; }
    }
}