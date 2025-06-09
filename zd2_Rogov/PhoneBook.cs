using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_Rogov
{
    public class PhoneBook
    {
        //Лист контактов
        private List<Contact> contacts = new List<Contact>();

        //Добавление контакта
        public void AddContact(Contact contact) => contacts.Add(contact);

        //Добавление контакта по индексу(перегрузка)
        public void AddContact(Contact contact, int index) => contacts.Insert(index, contact);

        //Удаление последнего контакта
        public void RemoveContact() => contacts.RemoveAt(contacts.Count - 1);

        //Удаление контакта по индексу(перегрузка)
        public void RemoveContact(int index) => contacts.RemoveAt(index-1);

        //Получение List с контактами по поиску
        public List<Contact> SearchContacts(string name) =>
            contacts.Where(c => c.Name.ToLower().Contains(name)).ToList();

        //Получение List всех контактов
        public List<Contact> GetAllContacts() => contacts;

        //Очистка всех контактов
        public void Clear() => contacts.Clear();

        //Получение количества контактов
        public int GetContactsCount() => contacts.Count;

        //Логический метод для сравнения конкретного контакта с контактами всей коллекции
        public bool ContainsContact(Contact contact)
        {
            return contacts.Any(c =>
                string.Equals(c.Name, contact.Name, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(c.Phone, contact.Phone, StringComparison.OrdinalIgnoreCase));
        }
        
    }
}
