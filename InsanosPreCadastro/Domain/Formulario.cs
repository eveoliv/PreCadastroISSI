using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsanosPreCadastro.Domain
{
    public class Formulario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Nome da Divisão")]
        public string Divisao { get; set; }

        [Required(ErrorMessage ="Campo obrigatório!")]
        [DisplayName("Nome no Colete")]
        public string NomeColete { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Número")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Complemento")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("UF")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("CEP")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Telefone Celular")]
        public string TelefoneCelular { get; set; }
       
        [DisplayName("Telefone Fixo")]
        public string TelefoneFixo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("E-mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Nome Contato Emergência")]
        public string NomeContatoEmergencia { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Telefone Contato Emergência")]
        public string TelefoneContatoEmergencia { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Profissão")]
        public string Profissao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Tamanho da Camiseta")]
        public string TamanhoCamiseta { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Tamanho do Colete")]
        public string TamanhoColete { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Material do Colete")]
        public string MaterialColete { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [DisplayName("Forma Pagamento do Colete")]
        public string FormaPagamentoColete { get; set; }
        
        public DateTime DataEnvio { get; set; }
        
    }
}

