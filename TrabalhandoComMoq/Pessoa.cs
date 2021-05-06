using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhandoComMoq
{
    public interface IVerificaIdade
    {
        string VerificaIdade(Pessoa p);
    }
    public class Pessoa: IVerificaIdade
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string telefone { get; set; }
        public int idade { get; set; }

        public string VerificaIdade(Pessoa p)
        {
            if (p.idade >= 21)
                return "Adulto";
            else
                return "Jovem ou criança";
        }

  
    }
}
