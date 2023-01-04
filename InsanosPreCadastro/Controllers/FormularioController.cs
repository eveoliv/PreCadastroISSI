using System;
using System.Linq;
using System.Threading.Tasks;
using InsanosPreCadastro.Data;
using Microsoft.AspNetCore.Mvc;
using InsanosPreCadastro.Domain;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace InsanosPreCadastro.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormularioController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View();

        public IActionResult Sucesso() => View();

        public IActionResult Cadastrado() => View();
        
        public async Task<IActionResult> Lista()
        {
            return View(await _context.Formulario.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formulario = await _context.Formulario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formulario == null)
            {
                return NotFound();
            }

            return View(formulario);
        }

        public IActionResult Create()
        {
            CriarListas();
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeColete,NomeCompleto,CPF,RG,DataNascimento,Endereco,Numero,Complemento,Bairro,Cidade,UF,CEP,TelefoneCelular,TelefoneFixo,Mail,NomeContatoEmergencia,TelefoneContatoEmergencia,Profissao,TamanhoCamiseta,TamanhoColete,MaterialColete,FormaPagamentoColete,DataEnvio,Divisao")] Formulario formulario)
        {
            if (string.IsNullOrEmpty(formulario.CPF))
            {
                CriarListas();
                return View(formulario);
            }

            var consulta = await _context.Formulario.Where(c => c.CPF == formulario.CPF).FirstOrDefaultAsync();
            if (consulta != null)
                return RedirectToAction(nameof(Cadastrado));

            if (ModelState.IsValid)
            {
                formulario.DataEnvio = DateTime.Now;
                _context.Add(formulario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Sucesso));
            }
            CriarListas();
            return View(formulario);
        }

        private void CriarListas()
        {
            var divisao = new List<string> { "Oeste - SP1", "Sul - SP1", "Extremo Norte - SP1", "Norte - Sp1", "Leste - SP1", "Extremo Oeste - SP1", "Extremo Sul - SP1", "Extremo Leste - SP1" };
            ViewBag.divisao = divisao;

            var uf = new List<string> { "SP", "RJ", "AC", "M", "RR", "PA", "AP", "TO", "MA", "PI", "CE", "RN", "PB", "PE", "AL", "SE", "BA", "MG", "ES", "RO", "PR", "SC", "RS", "MS", "MT", "GO", "DF" };
            ViewBag.uf = uf;

            var tamanho = new List<string> { "P", "G", "GG", "XG" };
            ViewBag.tamanho = tamanho;

            var colete = new List<string> { "Couro", "Sintético" };
            ViewBag.colete = colete;

            var pgto = new List<string>();
            for (int i = 1; i <= 3; i++) { pgto.Add($"{i}XBoleto"); }
            for (int i = 1; i <= 10; i++) { pgto.Add($"{i}XCartão"); }
            ViewBag.pgto = pgto;
        }

        /*
        // GET: Formularios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formulario = await _context.Formulario.FindAsync(id);
            if (formulario == null)
            {
                return NotFound();
            }
            return View(formulario);
        }

        // POST: Formularios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeColete,NomeCompleto,CPF,RG,DataNascimento,Endereco,Numero,Complemento,Bairro,Cidade,UF,CEP,TelefoneCelular,TelefoneFixo,Mail,NomeContatoEmergencia,TelefoneContatoEmergencia,Profissao,TamanhoCamiseta,TamanhoColete,MaterialColete,FormaPagamentoColete,DataEnvio")] Formulario formulario)
        {
            if (id != formulario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formulario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormularioExists(formulario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(formulario);
        }

        // GET: Formularios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formulario = await _context.Formulario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formulario == null)
            {
                return NotFound();
            }

            return View(formulario);
        }

        // POST: Formularios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formulario = await _context.Formulario.FindAsync(id);
            _context.Formulario.Remove(formulario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormularioExists(int id)
        {
            return _context.Formulario.Any(e => e.Id == id);
        }
    */
    }
}
