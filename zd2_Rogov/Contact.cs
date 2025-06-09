using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_Rogov
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        //Конструктор для контактов
        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
