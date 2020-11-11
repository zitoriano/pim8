using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.Models
{
    class Telefone
    {
        public int Id { get; set; }
        public long Numero { get; set; }
        public int DDD { get; set; }
        public int TipoId { get; set; }
        public TelefoneTipo Tipo { get; set; }
    }
}
