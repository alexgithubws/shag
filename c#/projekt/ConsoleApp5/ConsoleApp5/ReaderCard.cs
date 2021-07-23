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
            
        }
        private void MoveToArchive(StorageInfo obj)
        {

        }
        public void DelRecord(StorageInfo obj)
        {

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
    }
}
