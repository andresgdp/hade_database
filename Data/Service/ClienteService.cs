using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using hade_database.Data.Model;
namespace hade_database.Data.Service
{
    public class ClienteService : IClienteService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;
        public ClienteService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> ClienteInsert(Cliente cliente)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("dniCliente", cliente.dniCliente, DbType.Int32);
                parameters.Add("nombreCliente", cliente.nombreCliente, DbType.String);
                parameters.Add("apellidoCliente", cliente.apellidoCliente, DbType.String);
                parameters.Add("correoCliente", cliente.correoCliente, DbType.String);
                parameters.Add("direccionCliente", cliente.direccionCliente, DbType.String);

                const string query = @"INSERT INTO Cliente (dniCliente, nombreCliente, apellidoCliente,correoCliente, direccionCliente) VALUES (@dniCliente, @nombreCliente, @apellidoCliente,@correoCliente, @DireccionCliente)";
                await conn.ExecuteAsync(query, new
                {
                    cliente.dniCliente,
                    cliente.nombreCliente,
                    cliente.apellidoCliente,
                    cliente.correoCliente,
                    cliente.direccionCliente
                }, commandType: CommandType.Text);


            }
            return true;
        }
        public async Task<bool> ClienteUpdate(Cliente cliente)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("dniCliente", cliente.dniCliente, DbType.Int32);
                parameters.Add("nombreCliente", cliente.nombreCliente, DbType.String);
                parameters.Add("apellidoCliente", cliente.apellidoCliente, DbType.String);
                parameters.Add("correoCliente", cliente.correoCliente, DbType.String);
                parameters.Add("direccionCliente", cliente.direccionCliente, DbType.String);
                const string query = @"UPDATE Cliente
                    SET 
                        nombreCliente = @nombreCliente,
                        apellidoCliente = @apellidoCliente,
                        correoCliente = @correoCliente,
                        direccionCliente = @direccionCliente,
                        WHERE dniCliente = @dniCliente";
                await conn.ExecuteAsync(query, new
                {
                    cliente.dniCliente,
                    cliente.nombreCliente,
                    cliente.apellidoCliente,
                    cliente.correoCliente,
                    cliente.direccionCliente
                }, commandType: CommandType.Text);
            }
            return true;
        }
    }
}
