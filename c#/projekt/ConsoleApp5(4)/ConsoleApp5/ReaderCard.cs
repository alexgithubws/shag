using ConsoleApp5.SQliteCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ReaderCard
    {
        public Reader Reader { get; set; }
        private List<ReaderRecord> _records;
        private List<ReaderRecord> _archive;
        private SQLiteReaderCard _readerCard;
        public ReaderCard(Reader reader)
        {
            Reader = reader;
            _records = new List<ReaderRecord>(); //текущие
            _archive = new List<ReaderRecord>(); //история
            _readerCard = new SQLiteReaderCard();
        }
        public void AddRecord(StorageInfo obj)
        {
            _records.Add(new ReaderRecord() { Storage = obj, DateGive = DateTime.Now });
        }
        public void AddRecord(StorageInfo obj, DateTime dateTime)
        {
            _records.Add(new ReaderRecord() { Storage = obj, DateGive = dateTime });
        }
        private void MoveToArchive(StorageInfo obj)
        {
            ReaderRecord current = null;
            foreach (var item in _records) //список книг у него на руках
            {
                if (item.Storage.Equals(obj))
                {
                    current = item;
                }
            }
            if (current != null) {
                current.DateTake = DateTime.Now; //ставим отметку по возврату книги
                _archive.Add(current);
                _records.Remove(current);
            }
        }
        public void DelRecord(StorageInfo obj)
        {
            this.MoveToArchive(obj);
        }
        public List<ReaderRecord> ArchiveRecords
        {
            get
            {
                return _archive;
            }
        }
        public List<ReaderRecord> Records
        {
            get
            {
                return _records;
            }
        }
        public override string ToString()
        {
            string
            str = "-------------------------------HISTORY--------------------------------------------------\n";
            foreach (var item in _archive)
            {
                str += item + "\n";
            }
            str += "-------------------------------CURRENT--------------------------------------------------\n";
            foreach (var item in _records)
            {
                str += item + "\n";
            }
            str += "-------------------------------END--------------------------------------------------\n";
            return str;
        }

        private class SQLiteReaderCard : SQLiteUpEngins
        {
            public SQLiteReaderCard():base
            {
                "ReaderCard",
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyDateBase.sqlite"),
                    $"DataSource={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyDateBase.sqlite")}; Version = 3",
                    "'id' INTEGER PRIMARY SEY, 'library_id' INTEGER NOT NULL, 'reader_id' INTEGR NOT NULL,"+
                    "FOREGION KEY('library_id') REFERENCES Library(id),  FOREGION KEY('reader_id') REFERENCES(id)"
            }
    }
    }
}
