using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.DAO
{
    class ConnFactory : DbProviderFactory
    {
        private static DbConnection connection = null;

        // Driver
        private static DbProviderFactory factory;

        // Providers
        public const int MYSQL = 1;

        // Open a Database Connection
        public static DbConnection GetConnection(int type)
        {
            factory = new ConnFactory();

            switch (type)
            {
                case MYSQL:
                    try
                    {
                        string connectionString = "Server=10.0.0.12;" +
                            "Uid=root;" +
                            "Pwd=123456;" +
                            "Database=pim8;" +
                            "CharSet=utf8;";

                        factory = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
                        connection = factory.CreateConnection();
                        connection.ConnectionString = connectionString;
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw new Exception("Erro ao conectar com o banco de dados!");
                    }
                    break;
            }

            return connection;
        }

        // Return Factory Object
        public static DbProviderFactory GetFactory()
        {
            return factory;
        }

        // Create DBCommand Parameter
        public static DbParameter CreateParam(DbCommand cmd, string name, object value)
        {
            var param = cmd.CreateParameter();
            param.ParameterName = name;
            param.Value = value;

            return param;
        }
    }
}
