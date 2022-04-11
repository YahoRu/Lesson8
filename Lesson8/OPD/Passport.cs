using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.OPD
{
    public class Passport
    {
        private int _serial;
        private int _number;
        private string _issued;
        private DateTime _issuedDate;

        private bool IsActive { get; set; }

        private int Serial
        {
            get { return _serial; }
            set
            {
                if (value >= 1 && value <= 9999) _serial = value;
                else throw new ArgumentException("Неверная серия паспорта.");
            }
        }

        private int Number
        {
            get { return _number; }
            set
            {
                if (value >= 1 && value <= 999999) _number = value;
                else throw new ArgumentException("Неверный номер паспорта.");
            }
        }

        private string Issued
        {
            get { return _issued; }
            set
            {
                if (_issued != null) _issued = value;
                else throw new ArgumentException("Неверная прописка.");
            }
        }

        private DateTime IssuedDate
        {
            get { return _issuedDate; }
            set
            {
                if (value > new DateTime(1991, 12, 25) && value < DateTime.Now) _issuedDate = value;
                else throw new ArgumentException("Неверная дата регистрации.");
            }
        }

        

        public Passport(int serial, int number, string issued, DateTime issuedDate, bool isActive)
        {
            Serial = serial;
            Number = number;
            Issued = issued;
            IssuedDate = issuedDate;
            IsActive = isActive;
        }
    }
}
