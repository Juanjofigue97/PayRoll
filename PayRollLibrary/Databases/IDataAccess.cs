
namespace PayRollLibrary.Databases
{
    public interface IDataAccess
    {
        T FirstValue<T, U>(string sqlStatement, U parameters, string conexionString, dynamic? options = null);
        Task<T?> FirstValueAsync<T, U>(string sqlStatement, U parameters, string conexionString, dynamic? options = null);
        List<T> LoadData<T, U>(string sqlStatement, U parameters, string conexionString, dynamic? options = null);
        Task<List<T>> LoadDataAsync<T, U>(string sqlStatement, U parameters, string conexionString, dynamic? options = null);
        void SaveData<T>(string sqlStatement, T parameters, string conexionString, dynamic? options = null);
        Task SaveDataAsync<T>(string sqlStatement, T parameters, string conexionString, dynamic? options = null);
    }
}