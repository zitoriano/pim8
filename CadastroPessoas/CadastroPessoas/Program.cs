using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CadastroPessoas.Models;
using MySql.Data.MySqlClient;

namespace CadastroPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objeto Pessoa
            Pessoa pessoa = new Pessoa()
            {
                Id = 1,
                Nome = "Guilherme Zenatte",
                CPF = 12345678901,
                Endereco = new Endereco()
                {
                    Id = 1,
                    Logradouro = "Rua dos Crisântemos",
                    Numero = 75,
                    CEP = 13610000,
                    Bairro = "Centro",
                    Cidade = "São Paulo",
                    Estado = "SP"
                },
                Telefones = new List<Telefone>()
                {
                    new Telefone()
                    {
                        Id = 1,
                        Numero = 44442222,
                        DDD = 11,
                        TipoId = DAO.Telefone.RESIDENCIAL
                    },
                    new Telefone()
                    {
                        Id = 1,
                        Numero = 944442222,
                        DDD = 11,
                        TipoId = DAO.Telefone.CELULAR
                    }
                }
            };

            // Do Something...

            Console.ReadKey();
        }
    }
}
