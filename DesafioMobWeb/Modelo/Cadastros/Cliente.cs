using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class Cliente
    {
        [Display(Name = "Código")]
        public int ClienteID { get; set; }

        [Display(Name = "Razão Social")]
        public string RazaoSocialCliente { get; set; }

        [Display(Name = "Fantasia")]
        public string FantasiaCliente { get; set; }

        [Display(Name = "CNPJ")]
        public string CnpjCliente { get; set; }

        [Display(Name = "Logradouro")]
        public string RuaCliente { get; set; }

        [Display(Name = "Número")]
        public int NumeroRuaCliente { get; set; }

        [Display(Name = "Bairro")]
        public string BairroCliente { get; set; }

        [Display(Name = "Complemento")]
        public string ComplementoCliente { get; set; }

        [Display(Name = "Município")]
        public string MunicipioCliente { get; set; }

        [Display(Name = "CEP")]
        public string CepCliente { get; set; }

    }
}