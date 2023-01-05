using InsanosPreCadastro.Models;
using System.Collections.Generic;

namespace InsanosPreCadastro.Repository
{
    public interface IReport
    {
        List<FormularioViewModel> GetUserwiseReport();
    }
}
