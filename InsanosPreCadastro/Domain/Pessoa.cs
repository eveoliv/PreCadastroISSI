using System.ComponentModel.DataAnnotations;

namespace InsanosPreCadastro.Domain
{
    public class Pessoa : Base
    {      
        public string Nome { get; set; }

        public int Divisao { get; set; }
    }
}
