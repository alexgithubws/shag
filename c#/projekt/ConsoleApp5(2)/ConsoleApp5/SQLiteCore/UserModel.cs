using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.SQLiteCore
{
    class UserModel
    {
        private string _pathToDateBase;
        private string _connectionString;
        private string _LableName;
        private SQLiteConnection _connect;
        private List<KeyValuePair<string, string>> _fieldName;
        private List<List<string>>

        public UserModel(string tableName)
        {
            _tableName = tableName;
            _pathToDateBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyDataBase.sqlite");
            _connectionString = $"DataSource={_pathToDateBase}; Version =3;";
            _connect = new SQLiteConnection(_connectionString);

            _fieldName = new List<KeyValuePair<string, string>>();
            _fielData = new List<List<string>>();
            this.uplodDate();
        }
    }
}
