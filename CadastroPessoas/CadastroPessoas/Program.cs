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
                Nome = "Diego Araujo Rocha",
                CPF = 12345678901,
                Endereco = new Endereco()
                {
                    Logradouro = "Vila Dona Leopoldina",
                    Numero = 1237,
                    CEP = 60110010,
                    Bairro = "Aldeota",
                    Cidade = "Fortaleza",
                    Estado = "CE"
                },
                Telefones = new List<Telefone>()
                {
                    new Telefone()
                    {
                        Numero = 56157859,
                        DDD = 85,
                        TipoId = DAO.Telefone.RESIDENCIAL
                    },
                    new Telefone()
                    {
                        Numero = 956157859,
                        DDD = 85,
                        TipoId = DAO.Telefone.CELULAR
                    }
                }
            };

            // Grava o dados no banco
            new DAO.Pessoa().Insert(pessoa);

            // Localiza a pessoa por CPF
            pessoa = new DAO.Pessoa().FindByCPF(12345678901);

            // Modifica o nome da pessoa
            pessoa.Nome = "Diego A Rocha";

            // Grava as modificações no banco novamente
            new DAO.Pessoa().Update(pessoa);

            // Printa o nome da pessoa modificado
            Console.WriteLine(pessoa.Nome);
        }
    }
}
