using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CadastroPessoas.DAO
{
    class Pessoa : IPessoa
    {
        private DbConnection conn;

        public Pessoa()
        {
            conn = ConnFactory.GetConnection(ConnFactory.MYSQL);
        }

        public Models.Pessoa Find(int Id)
        {
            Models.Pessoa pessoa = new Models.Pessoa();

            var sql = "SELECT * FROM Pessoa WHERE id = @Id";

            try
            {
                // Create connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "Id", Id));

                cmd.ExecuteNonQuery();

                // Data Set
                DbDataReader data = cmd.ExecuteReader();

                // Get Rows and Read Data
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        pessoa.Id = data.GetInt32(0);
                        pessoa.Nome = data.GetString(1);
                        pessoa.CPF = data.GetInt64(2);
                        pessoa.EnderecoId = Convert.ToInt32(data.GetInt32(3));
                        pessoa.Telefones = new Telefone().GetPhones(pessoa.Id);

                        if (pessoa.EnderecoId > 0)
                        {
                            pessoa.Endereco = new Endereco().Find(pessoa.EnderecoId);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return pessoa;
        }

        public Models.Pessoa FindByCPF(long CPF)
        {
            Models.Pessoa pessoa = new Models.Pessoa();

            var sql = "SELECT * FROM Pessoa WHERE cpf = @CPF";

            try
            {
                // Create connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "CPF", CPF));

                cmd.ExecuteNonQuery();

                // Data Set
                DbDataReader data = cmd.ExecuteReader();

                // Get Rows and Read Data
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        pessoa.Id = data.GetInt32(0);
                        pessoa.Nome = data.GetString(1);
                        pessoa.CPF = data.GetInt64(2);
                        pessoa.EnderecoId = Convert.ToInt32(data.GetInt32(3));
                        pessoa.Telefones = new Telefone().GetPhones(pessoa.Id);

                        if (pessoa.EnderecoId > 0)
                        {
                            pessoa.Endereco = new Endereco().Find(pessoa.EnderecoId);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return pessoa;
        }

        public bool Insert(Models.Pessoa pessoa)
        {
            string sql = "INSERT INTO " +
                         "Pessoa (nome, cpf, enderecoId) " +
                         "VALUES (@nome, @cpf, @enderecoId); " +
                         "SELECT LAST_INSERT_ID();";

            try
            {
                if (pessoa.Endereco.Id == 0 && pessoa.Endereco.Logradouro != null)
                {
                    // Register Adress
                    pessoa.Endereco.Id = new DAO.Endereco().Insert(pessoa.Endereco);
                }

                // Open Connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "nome", pessoa.Nome));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "cpf", pessoa.CPF));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "enderecoId", pessoa.Endereco.Id));

                //cmd.ExecuteNonQuery();
                object Id = cmd.ExecuteScalar();

                // Get Latest Id
                int pessoaId = Convert.ToInt32(Id);

                // Add Phones
                foreach (Models.Telefone fone in pessoa.Telefones)
                {
                    new Telefone().Insert(fone, pessoaId);
                }

                // Add Address

                // Close Connection
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Close Connection
                conn.Close();
            }

            return false;
        }

        public bool Update(Models.Pessoa pessoa)
        {
            string sql = "UPDATE Pessoa " +
                         "SET nome=@nome," +
                         "cpf=@cpf " +
                         "WHERE id = @id";

            try
            {
                // Open Connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "nome", pessoa.Nome));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "cpf", pessoa.CPF));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "id", pessoa.Id));

                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool Delete(Models.Pessoa pessoa)
        {
            string sql = "DELETE FROM Pessoa " +
                         "WHERE id = @id";

            try
            {
                // Open Connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "id", pessoa.Id));

                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }
    }
}
