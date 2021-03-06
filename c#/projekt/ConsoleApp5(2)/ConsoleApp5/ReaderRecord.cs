using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ReaderRecord
    {
        public StorageInfo Storage { get; set; }
        public DateTime DateGive { get; set; }
        public DateTime DateTake { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"DateGive: { DateGive}; \n" +
                $"DateTake: {DateTake}; \n";

        }
    }
}
