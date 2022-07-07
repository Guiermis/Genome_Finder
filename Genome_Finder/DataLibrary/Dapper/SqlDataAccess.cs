using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Genome_Finder.DataLibrary.Dapper
{
    public static class SqlDataAccess
    {
        public static string GetConnectionString(string ConnectionString = "Data Source=PC-DE-GUILHERME;Initial Catalog=Genome_Finder;Integrated Security=True")
        {
            return ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static int UpdateData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }
    }
}
