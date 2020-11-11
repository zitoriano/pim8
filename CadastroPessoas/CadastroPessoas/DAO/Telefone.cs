using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.DAO
{
    class Telefone : ITelefone
    {
        private DbConnection conn;

        // Phone Type
        public const int RESIDENCIAL = 1;
        public const int CELULAR = 2;

        public Telefone()
        {
            conn = ConnFactory.GetConnection(ConnFactory.MYSQL);
        }

        public Models.Telefone Find(int Id)
        {
            Models.Telefone fone = new Models.Telefone();

            var sql = "SELECT * FROM Telefone WHERE id = @Id";

            try
            {
                // Reopen Connection if needed
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn = ConnFactory.GetConnection(ConnFactory.MYSQL);

                // Create connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "Id", Id));

                // Reopen Connection if needed
                if(conn.State == System.Data.ConnectionState.Closed)
                    conn = ConnFactory.GetConnection(ConnFactory.MYSQL);

                cmd.ExecuteNonQuery();

                // Data Set
                DbDataReader data = cmd.ExecuteReader();

                // Get Rows and Read Data
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        fone.Id = data.GetInt32(0);
                        fone.Numero = data.GetInt64(1);
                        fone.DDD = data.GetInt32(2);
                        fone.TipoId = data.GetInt32(3);
                    }
                }

                // Close DataSet
                conn.Close();

                // Get Phone Type
                fone.Tipo = GetType(fone.TipoId);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Connection Closed
                conn.Close();
            }

            return fone;
        }

        public bool Insert(Models.Telefone fone)
        {
            string sql = "INSERT INTO " +
                         "Telefone (numero, ddd, tipoId) " +
                         "VALUES (@numero, @ddd, @tipoId)";

            try
            {
                // Open Connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "numero", fone.Numero));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "ddd", fone.DDD));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "tipoId", fone.TipoId));

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

        public bool Insert(Models.Telefone fone, int pessoaId)
        {
            string sql = "INSERT INTO " +
                         "Telefone (numero, ddd, tipoId) " +
                         "VALUES (@numero, @ddd, @tipoId);" +
                         "SELECT LAST_INSERT_ID();";

            try
            {
                // Open Connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "numero", fone.Numero));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "ddd", fone.DDD));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "tipoId", fone.TipoId));

                object Id = cmd.ExecuteScalar();

                // Get Latest Id
                int foneId = Convert.ToInt32(Id);

                // Add Relation
                DbCommand cmd2 = ConnFactory.GetFactory().CreateCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "INSERT INTO Pessoa_Telefone " +
                        "(pessoaId, telefoneId) " +
                        "VALUES (@pessoaId, @telefoneId)";

                // Set Parameteres
                cmd2.Parameters.Add(
                    ConnFactory.CreateParam(cmd2, "pessoaId", pessoaId));
                cmd2.Parameters.Add(
                    ConnFactory.CreateParam(cmd2, "telefoneId", foneId));

                cmd2.ExecuteNonQuery();

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

        public bool Update(Models.Telefone fone)
        {
            string sql = "UPDATE Telefone SET " +
                         "numero=@numero, ddd=@ddd " +
                         "WHERE id=@id";

            try
            {
                // Open Connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "numero", fone.Numero));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "ddd", fone.DDD));
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "id", fone.Id));

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

        public bool Delete(Models.Telefone fone)
        {
            string sql = "DELETE FROM Pessoa_Telefone " +
                         "WHERE telefoneId=@id; " +
                         "DELETE FROM Telefone " +
                         "WHERE id=@id";

            try
            {
                // Open Connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "id", fone.Id));

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

        public List<Models.Telefone> GetPhones(int pessoaId)
        {
            List<Models.Telefone> telefones = new List<Models.Telefone>();

            var sql = "SELECT * FROM Pessoa_Telefone WHERE pessoaId = @Id";

            try
            {
                // Open connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "Id", pessoaId));

                cmd.ExecuteNonQuery();

                // Data Set
                DbDataReader data = cmd.ExecuteReader();

                // List Phone Ids
                List<int> phoneIds = new List<int>();

                // Get Rows and Read Data
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        phoneIds.Add(data.GetInt32(1));
                    }
                }

                data.Close();

                foreach(int phoneId in phoneIds)
                {
                    telefones.Add(Find(phoneId));
                }

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

            return telefones;
        }

        public Models.TelefoneTipo GetType(int tipoId)
        {
            Models.TelefoneTipo tipo = new Models.TelefoneTipo();

            var sql = "SELECT * FROM Telefone_Tipo WHERE id = @Id";

            try
            {
                // Reopen Connection if needed
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn = ConnFactory.GetConnection(ConnFactory.MYSQL);

                // Open connection
                DbCommand cmd = ConnFactory.GetFactory().CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Set Parameteres
                cmd.Parameters.Add(
                    ConnFactory.CreateParam(cmd, "Id", tipoId));

                cmd.ExecuteNonQuery();

                // Data Set
                DbDataReader data = cmd.ExecuteReader();

                // Get Rows and Read Data
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        tipo.Id = data.GetInt32(0);
                        tipo.Tipo = data.GetString(1);
                    }
                }
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

            return tipo;
        }
    }
}
