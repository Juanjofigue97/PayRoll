using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PayRoll_Infrastructure.Databases;

public class SqlDataAccess : IDataAccess
{
    private readonly IConfiguration _config;
    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }
    public T FirstValue<T, U>(string sqlStatement,
                              U parameters,
                              string conexionStringName,
                              dynamic? options = null)
    {
        string conexionString = _config.GetConnectionString(conexionStringName)!;
        CommandType commandType = CommandType.Text;

        if (options?.IsStoredProcedure != null && options?.IsStoredProcedure == true)
        {
            commandType = CommandType.StoredProcedure;
        }

        using (IDbConnection connection = new SqlConnection(conexionString))
        {
            T rows = connection.QueryFirst<T>(sqlStatement, parameters, commandType: commandType);
            return rows;
        }
    }
    public async Task<T?> FirstValueAsync<T, U>(string sqlStatement,
                                                U parameters,
                                                string conexionStringName,
                                                dynamic? options = null)
    {
        string conexionString = _config.GetConnectionString(conexionStringName)!;
        CommandType commandType = CommandType.Text;
        if (options?.IsStoredProcedure != null && options?.IsStoredProcedure == true)
        {
            commandType = CommandType.StoredProcedure;
        }
        using (IDbConnection connection = new SqlConnection(conexionString))
        {
            T? rows = await connection.QueryFirstOrDefaultAsync<T>(sqlStatement, parameters, commandType: commandType);
            return rows;
        }
    }

    public List<T> LoadData<T, U>(string sqlStatement,
                                  U parameters,
                                  string conexionStringName,
                                  dynamic? options = null)
    {
        string conexionString = _config.GetConnectionString(conexionStringName)!;
        CommandType commandType = CommandType.Text;

        if (options?.IsStoredProcedure != null && options?.IsStoredProcedure == true)
        {
            commandType = CommandType.StoredProcedure;
        }

        using (IDbConnection connection = new SqlConnection(conexionString))
        {
            var rows = connection.Query<T>(sqlStatement, parameters, commandType: commandType);
            return rows.ToList();
        }
    }

    public async Task<List<T>> LoadDataAsync<T, U>(string sqlStatement,
                                                   U parameters,
                                                   string conexionStringName,
                                                   dynamic? options = null)
    {
        string conexionString = _config.GetConnectionString(conexionStringName)!;
        CommandType commandType = CommandType.Text;

        if (options?.IsStoredProcedure != null && options?.IsStoredProcedure == true)
        {
            commandType = CommandType.StoredProcedure;
        }

        using (IDbConnection connection = new SqlConnection(conexionString))
        {
            var rows = await connection.QueryAsync<T>(sqlStatement, parameters, commandType: commandType);
            return rows.ToList();
        }
    }
    public void SaveData<T>(string sqlStatement,
                            T parameters,
                            string conexionStringName,
                            dynamic? options = null)
    {
        string conexionString = _config.GetConnectionString(conexionStringName)!;
        CommandType commandType = CommandType.Text;

        if (options?.IsStoredProcedure != null && options?.IsStoredProcedure == true)
        {
            commandType = CommandType.StoredProcedure;
        }
        using (IDbConnection connection = new SqlConnection(conexionString))
        {
            connection.Execute(sqlStatement, parameters, commandType: commandType);
        }
    }
    public async Task SaveDataAsync<T>(string sqlStatement,
                                       T parameters,
                                       string conexionStringName,
                                       dynamic? options = null)
    {
        string conexionString = _config.GetConnectionString(conexionStringName)!;
        CommandType commandType = CommandType.Text;

        if (options?.IsStoredProcedure != null && options?.IsStoredProcedure == true)
        {
            commandType = CommandType.StoredProcedure;
        }
        using (IDbConnection connection = new SqlConnection(conexionString))
        {
            await connection.ExecuteAsync(sqlStatement, parameters, commandType: commandType);
        }
    }
}
