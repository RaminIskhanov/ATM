using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class User : Card
    {
        public string Name;
        public string SurName;
       
        Card CreditCard;
       
        public User(Card creditCard)
        {
            CreditCard = creditCard;
        }

        public User(string name, string surname)
        {
            Name = name;
            SurName = surname;

        }
    }
}
