using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_Rogov
{
    public static class PhoneBookLoader
    {
        //Метод загрузки из файла 
        public static void Load(PhoneBook phoneBook, string fileName)
        {
            if (!File.Exists(fileName)) return;

            var lines = File.ReadAllLines(fileName);
            var contacts = lines
                .Select(line => line.Split(';'))
                .Select(parts => new Contact(parts[0], parts[1]));

            phoneBook.Clear();
            foreach (var contact in contacts)
            {
                phoneBook.AddContact(contact);
            }
        }
        //Метод сохранения в файл
        public static void Save(PhoneBook phoneBook, string fileName)
        {
            var lines = phoneBook.GetAllContacts().Select(c => $"{c.Name};{c.Phone}");
            File.WriteAllLines(fileName, lines);
        }
    }
}
