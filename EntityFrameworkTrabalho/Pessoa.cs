using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTrabalho
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public DateTime dataNasc { get; set; }
        public string estadoCivil { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string cidade { get; set; }
    }
}
