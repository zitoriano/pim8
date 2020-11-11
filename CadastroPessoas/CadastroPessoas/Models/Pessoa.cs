using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.Models
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
    }
}
