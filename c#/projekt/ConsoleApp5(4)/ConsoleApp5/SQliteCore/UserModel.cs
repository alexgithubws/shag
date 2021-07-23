using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.SQliteCore
{
    class UserModel
    {
        private string _pathToDataBase;
        private string _connectionString;
        private string _tableName;
        private SQLiteConnection _connect;
        private List<KeyValuePair<string, string>> _fieldNames;
        private List<List<string>> _fieldData;
        public UserModel(string tableName)
        {
            _tableName = tableName;
            _pathToDataBase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyDataBase.sqlite");
            _connectionString = $"DataSource={_pathToDataBase}; Version=3;";
            _connect = new SQLiteConnection(_connectionString);

            _fieldNames = new List<KeyValuePair<string, string>>();
            _fieldData = new List<List<string>>();
            this.uploadData();
        }

        private void uploadData()
        {
            _connect.Open();
            SQLiteCommand sQLiteCommand = new SQLiteCommand($"PRAGMA table_info({_tableName})", _connect);
            SQLiteDataReader fieldsInfoReader = sQLiteCommand.ExecuteReader();

            foreach (DbDataRecord field in fieldsInfoReader)
            {
                _fieldNames.Add(new KeyValuePair<string, string>(field.GetString(1), field.GetString(2)));
            }

            sQLiteCommand = new SQLiteCommand($"SELECT * FROM {_tableName}", _connect);
            foreach (DbDataRecord row in sQLiteCommand.ExecuteReader())
            {
                List<string> tmp = new List<string>();
                for (int i = 0; i < row.FieldCount; i++)
                {
                    tmp.Add(row.GetValue(i).ToString());
                }
                _fieldData.Add(tmp);
            }
            _connect.Close();
        }
        public List<string> this[int index] //получить доступ к одной строке
        {
            get
            {
                return _fieldData[index];
            }
        }
        //addRow
        //deleteRow
        //updateRow

        //update -- сохранить проделанную работу в файл
    }
}
