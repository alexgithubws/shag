using System;
using System.Collections.Generic;
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

        public ReaderCard(Reader reader)
        {
            Reader = reader;
            _records = new List<ReaderRecord>();
            _archive = new List<ReaderRecord>();
        }
        public void AddRecord(StorageInfo obj)
        {
            _records.Add(new ReaderRecord() { Storage = obj, DateGive = DateTime.Now });                                                                                                                                                                                                                                                                             
        }

        public void MoveToArchive(StorageInfo obj)
        {
            ReaderRecord current = null;
            foreach (var item in _records)
            {
                if (item.Storage.Equals(obj))
                {
                    current = item;
                }

            }
            if (current != null)
            {
                current.DateTake = DateTime.Now;
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
        /*public override string ToString()
        {
            string str = " -----histori------\n";
            foreach (var item in _archive)
            {
                
            }
        }*/

    }
}
