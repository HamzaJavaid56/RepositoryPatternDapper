using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace AppDataAccess
{
    public interface IDbRepository
    {
        int Execute(string query, object param);
        int Execute(string query, object param, CommandType commandType);
        int Execute(string query, CommandType commandType);
        Task<int> ExecuteAsync(string query, object param, CommandType commandType);
        T QuerySingleOrDefault<T>(string query, object param);
        T QuerySingleOrDefault<T>(string query, CommandType commandType);
        Task<T> QuerySingleOrDefaultAsync<T>(string query, CommandType commandType);
        T QuerySingleOrDefault<T>(string query, object param, CommandType commandType);
        IEnumerable<T> Query<T>(string query, object param);
        IEnumerable<T> Query<T>(string query, object param, CommandType commandType, bool timeout);
        IEnumerable<T> Query<T>(string query, CommandType commandType);
        IEnumerable<T> Query<T>(string query, object param, CommandType commandType);
        Task<T> QuerySingleOrDefaultAsync<T>(string query, object param, CommandType commandType);
        Task<T> QuerySingleOrDefaultWithTimeOutAsync<T>(string query, object param, CommandType commandType, int timeOutInSeconds);
        Task<IEnumerable<T>> QueryAsync<T>(string query, object param, CommandType commandType);
        Task<IEnumerable<T>> QueryAsync<T>(string query, object param);
        Task<T> ExecuteScalarAsync<T>(string query, object param, CommandType commandType);
        Task<Tuple<IEnumerable<T1>, IEnumerable<T2>>> QueryMultipleAsync<T1, T2>(string query, object param, CommandType commandType);
        Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>>> QueryMultipleAsync<T1, T2, T3>(string query, object param, CommandType commandType);
        Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>>> QueryMultipleAsync<T1, T2, T3, T4>(string query, object param, CommandType commandType);
        Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>>> QueryMultipleAsync<T1, T2, T3, T4, T5>(string query, object param, CommandType commandType);
    }
}
