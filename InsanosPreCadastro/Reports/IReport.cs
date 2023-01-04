using InsanosPreCadastro.Models;
using System.Collections.Generic;

namespace InsanosPreCadastro.Reports
{
    public interface IReport
    {
        List<FormularioViewModel> GetUserwiseReport();
    }
}
