using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.DAO
{
    interface IPessoa
    {
        Models.Pessoa Find(int Id);
        Models.Pessoa FindByCPF(long CPF);
        bool Insert(Models.Pessoa pessoa);
        bool Update(Models.Pessoa pessoa);
        bool Delete(Models.Pessoa pessoa);
    }
}
