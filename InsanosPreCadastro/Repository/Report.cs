using System;
using System.Linq;
using InsanosPreCadastro.Data;
using InsanosPreCadastro.Models;
using System.Collections.Generic;

namespace InsanosPreCadastro.Repository
{
    public class Report : IReport
    {
        private readonly ApplicationDbContext _context;

        public Report(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<FormularioViewModel> GetUserwiseReport()
        {
            try
            {
                var lista = _context.Formulario.ToList();

                var listaFormatada = new List<FormularioViewModel>();
                foreach (var item in lista)
                {
                    listaFormatada.Add(new FormularioViewModel
                    {
                        NomeColete = item.NomeColete,
                        NomeCompleto =item.NomeCompleto,
                        NomeContatoEmergencia = item.NomeContatoEmergencia,
                        Bairro = item.Bairro,
                        CEP = item.CEP,
                        Endereco = item.Endereco,
                        DataEnvio = item.DataEnvio.ToString(),
                        DataNascimento = item.DataNascimento.ToString("dd/MM/yyyy"),
                        Divisao = item.Divisao,
                        Cidade = item.Cidade,
                        Complemento = item.Complemento,
                        CPF = item.CPF,
                        FormaPagamentoColete = item.FormaPagamentoColete,
                        TelefoneContatoEmergencia = item.TelefoneContatoEmergencia,
                        TamanhoCamiseta = item.TamanhoCamiseta,
                        TamanhoColete = item.TamanhoColete,
                        TelefoneCelular = item.TelefoneCelular,
                        TelefoneFixo = item.TelefoneFixo,
                        Mail = item.Mail,
                        MaterialColete = item.MaterialColete,
                        Numero = item.Numero,
                        Profissao = item.Profissao,
                        RG = item.RG,
                        UF = item.UF                        
                    });
                }

                return listaFormatada;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.ToString());
            }
        }
    }
}
