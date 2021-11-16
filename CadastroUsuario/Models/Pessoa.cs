using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuario.Models
{
    public class Pessoa
    {
        public int Pessoaid { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Data de nascimento")]
        public string DataNascimento { get; set; }
               
        [Display(Name = "CPF/CNPJ")]
        public string CPFCNPJ { get; set; }

        [Display(Name = "Física/Jurídica")]
        public string TipoPessoa { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Número")]
        public string Número { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        public bool Ativo { get; set; }
    }
}