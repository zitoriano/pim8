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
            // Cria um objeto pessoa com os todos os dados
            Pessoa pessoa = new Pessoa()
            {
                Id = 1,
                Nome = "Guilherme Zenatte",
                CPF = 12345678901,
                Endereco = new Endereco()
                {
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
                        Numero = 44442222,
                        DDD = 11,
                        TipoId = DAO.Telefone.RESIDENCIAL
                    },
                    new Telefone()
                    {
                        Numero = 944442222,
                        DDD = 11,
                        TipoId = DAO.Telefone.CELULAR
                    }
                }
            };

            // Grava o dados no banco
            new DAO.Pessoa().Insert(pessoa);

            // Localiza a pessoa por CPF
            pessoa = new DAO.Pessoa().FindByCPF(12345678901);

            // Modifica o nome da pessoa
            pessoa.Nome = "Guilherme Zanette";

            // Grava as modificações no banco novamente
            new DAO.Pessoa().Update(pessoa);

            // Printa o nome da pessoa modificado
            Console.WriteLine(pessoa.Nome);
        }
    }
}
