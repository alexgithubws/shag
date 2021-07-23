using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library
{
    enum ReaderRate
    {
        Neitural,
        Fail,
        Satisfactory,
        Good,
        Very_Good,
        Excellent
    }
    class Reader: Human
    {
        private string _email;
        private string _phone;
        private string _adress;
        
        public ReaderRate Rate
        {
            get; set;
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (new Regex(@"^[^@]{3,}@[^@]{3,}$").IsMatch(value))
                    _email = value;
                else
                    throw new ArgumentException("Email address is invalid");
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (new Regex(@"^\+\d{12}$").IsMatch(value))
                    _phone = value;
                else
                    throw new ArgumentException("Phone address is invalid");
            }
        }
        public string Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
            }
        }

        public Reader(string name, string surname, DateTime birthDate, Gender gender, string email, string phone, string adress, ReaderRate readerRate)
            :base(name, surname, birthDate, gender)
        {
            this.Rate = readerRate;
            Adress = adress;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\n\tRate: {Rate}; " +
                $"\n\tEmail: {Email}; " +
                $"\n\tPhone: {Phone}; " +
                $"\n\tAdress: {Adress}; ";
        }
    }
}
