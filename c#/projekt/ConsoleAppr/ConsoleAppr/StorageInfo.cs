using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppr
{
   abstract class StorageInfo:IStorrage
    {
        public Genres Gener { get;set }

        public Langs Lang { get;set }

        private DateTime _dateOfPublished;

        public DateTime DaTEPublish
        {
            protected set
            {
                if (value < DateTime.Now)
                {
                    _dateOfPublished = value;
                }
                else
                {
                    throw 
                }
            }
        }
    }
}
