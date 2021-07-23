using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.SQliteCore
{
    abstract class SQLiteUpEngins
    {
        protected string _TabeleName;
        protected string _pathToDateDase;
        protected string _connectionString;
        protected SQLiteConnection _connect;

        static protected List<KeyValuePair<string, string>> _fielnIdName = new List<KeyValuePair<string, string>>();

        public List<KeyValuePair<string, string>> FileIdName
        {
            get;
        }

        public void updateFielIdName()
        {
            _connect.Open();
            SQLiteCommand sQLiteCommand = new SQLiteCommand($"PRAGMA table_info('{_TabeleName}')", _connect);
            SQLiteDataReader fieldsInfoReader = SQLiteCommand.ExecuteReader();

            foreach (DbDateRecord fieid in fieldsInfoReader)
            {
                _fielnIdName.Add(new KeyValuePair<string, string>(fieid.GetString(1), fieid.Getstring(2));
            }

            _connect.Close();
        }
    
        public SQLiteUpEngins(string TableName, string pathToDataBase, string connectionString,string field)
        {
            _TabeleName = TableName;
            _pathToDateDase = pathToDataBase;
            if (!File.Exists(_pathToDateDase))
            {
                SQLiteConnection.CreateFile(_pathToDateDase);
            }
            _connectionString = connectionString;
            _connect = new SQLiteConnection(_connectionString);
            creat_table(field);
            upadate_fieldName();
        }

        private void upadate_fieldName()
        {
            throw new NotImplementedException();
        }

        private void creat_table(string field)
        {
            throw new NotImplementedException();
        }
    }
}
