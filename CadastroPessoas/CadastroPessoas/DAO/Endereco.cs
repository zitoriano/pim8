using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.DAO
{
    class Endereco : IEndereco
    {
        private DbConnection conn;

        public Endereco()
        {
            conn = ConnFactory.GetConnection(ConnFactory.MYSQL);
        }

        public Models.Endereco Find(int Id)
        {
            Models.Endereco endereco = new Models.Endereco();

            var sql = "SELECT * FROM Endereco WHERE id = @Id";

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
                        endereco.Id = data.GetInt32(0);
                        endereco.Logradouro = data.GetString(1);
                        endereco.Numero = data.GetInt32(2);
                        endereco.CEP = data.GetInt64(3);
                        endereco.Bairro = data.GetString(4);
                        endereco.Cidade = data.GetString(5);
                        endereco.Estado = data.GetString(6);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return endereco;
        }

        public int Insert(Models.Endereco endereco)
        {
            string sql = "INSERT INTO " +
                         "Endereco (logradouro, numero, cep, bairro, cidade, estado) " +
                         "VALUES (@logradouro, @numero, @cep, @bairro, @cidade, @estado);" +
                         "SELECT LAST_INSERT_ID();";

            int lastId;

            try
            {
                // Open Connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "logradouro", endereco.Logradouro));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "numero", endereco.Numero));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "cep", endereco.CEP));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "bairro", endereco.Bairro));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "cidade", endereco.Cidade));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "estado", endereco.Estado));

                object Id = cmd.ExecuteScalar();

                // Get Latest Id
                lastId = Convert.ToInt32(Id);

                // Close Connection
                conn.Close();

                return lastId;
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

            return -1;
        }

        public bool Update(Models.Endereco endereco)
        {
            string sql = "UPDATE Endereco SET " +
                         "logradouro=@logradouro, numero=@numero, cep=@cep, " +
                         "bairro=@bairro, cidade=@cidade, estado=@estado " +
                         "WHERE id=@id; ";

            try
            {
                // Open Connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "logradouro", endereco.Logradouro));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "numero", endereco.Numero));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "cep", endereco.CEP));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "bairro", endereco.Bairro));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "cidade", endereco.Cidade));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "estado", endereco.Estado));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "id", endereco.Id));

                cmd.ExecuteNonQuery();

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

        public bool Delete(Models.Endereco endereco)
        {
            string sql = "DELETE FROM Endereco WHERE id=@id; ";

            try
            {
                // Open Connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "id", endereco.Id));

                cmd.ExecuteNonQuery();

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
    }
}
