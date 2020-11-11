using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.DAO
{
    interface ITelefone
    {
        Models.Telefone Find(int Id);
        bool Insert(Models.Telefone fone);
        bool Insert(Models.Telefone fone, int pessoaId);
        bool Update(Models.Telefone fone);
        bool Delete(Models.Telefone fone);
        List<Models.Telefone> GetPhones(int pessoaId);
        Models.TelefoneTipo GetType(int tipoId);
    }
}
