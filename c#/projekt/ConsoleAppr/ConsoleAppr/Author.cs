using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
	class Author:Human
	{
		string _bibliography;
		public Author() : base()
        {

        }
        public Author(string name, string surname, DateTime birthDate, Gender gender, string biography)
            : base(name, surname, birthDate, gender)
        {

        }
		public string Biography
        {
            get
            {
                return _bibliography;
            }
            set
            {
                if(value.Length >= 3)
                {
                    _bibliography = value;
                }
                else
                {
                    throw new ArgumentException("biografiya ne mojet byt pustoy");
                }
            }
        }

	}
}