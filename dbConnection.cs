using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DotNetEnv;

namespace modelo_finanzas
{
    public class DbConnection
    {
        private readonly string _connectionString;
        private static DbConnection? _instance;

        private DbConnection()
        {
            Env.TraversePath().Load();

            string dbUser = Environment.GetEnvironmentVariable("DB_USER") ?? "";
            string dbPass = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "";
            string dbPort = Environment.GetEnvironmentVariable("DB_PORT") ?? "1433";

            var builder = new SqlConnectionStringBuilder
            {
                DataSource = @"localhost,1435",
                InitialCatalog = "hausencito247_finanzas",
                UserID = dbUser,
                Password = dbPass,
                Encrypt = true,
                TrustServerCertificate = true, 
                MultipleActiveResultSets = true,
                
            };

            _connectionString = builder.ConnectionString;
        }

        public static DbConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DbConnection();
                }
                return _instance;
            }
        }

        public async Task<SqlConnection> GetConnectionAsync()
        {
            var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();
            return connection;
        }

        public async Task<bool> TestConnectionAsync()
        {
            try
            {
                await using var connection = await GetConnectionAsync();
                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.InnerException);
                return false;
            }
        }
    }
}