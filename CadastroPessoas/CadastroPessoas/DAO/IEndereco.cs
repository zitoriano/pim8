using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.DAO
{
    interface IEndereco
    {
        Models.Endereco Find(int Id);
        int Insert(Models.Endereco endereco);
        bool Update(Models.Endereco endereco);
        bool Delete(Models.Endereco endereco);
    }
}
