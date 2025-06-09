using System.Xml.Linq;

namespace zd2_Rogov
{
    public partial class Form1 : Form
    {
        //Создание телефонной книжки
        private PhoneBook phoneBook = new PhoneBook();

        //Путь к файлу
        private string currentFile = "contacts.csv";
        public Form1()
        {
            InitializeComponent();
            PhoneBookLoader.Load(phoneBook, currentFile);
            UpdateListBox();

            //Ограничение для numericUpDown
            numericUpDownInsert.Maximum = phoneBook.GetContactsCount()+1;
            numericUpDownRemove.Maximum = phoneBook.GetContactsCount();
        }

        //Проверка на буквы в номере
        private bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            foreach (char c in phone)
            {
                if (!char.IsDigit(c) && (c != '+' || phone.IndexOf(c) != 0))
                {
                    return false;
                }
            }
            return true;
        }

        //Вывести ListBox 
        private void UpdateListBox()
        {
            listBoxContacts.Items.Clear();
            foreach (var contact in phoneBook.GetAllContacts())
            {
                listBoxContacts.Items.Add($"{contact.Name}: {contact.Phone}");
            }
            numericUpDownInsert.Maximum = phoneBook.GetContactsCount()+1;
            numericUpDownRemove.Maximum = phoneBook.GetContactsCount();
            textSearch.Clear();
        }

        //Вывести ListBox по конкретной коллекции (например отсортированной)
        private void UpdateListBox(List<Contact> contacts)
        {
            listBoxContacts.Items.Clear();
            foreach (var contact in contacts)
            {
                listBoxContacts.Items.Add($"{contact.Name}: {contact.Phone}");
            }
        }

        //Кнопка поиска по словам
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textSearch.Text)){
                var found = phoneBook.SearchContacts(textSearch.Text.ToLower());
                UpdateListBox(found);
            } else MessageBox.Show("Введите слова для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Кнопка добавления
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textPhone.Text))
            {
                MessageBox.Show("Введите имя и телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPhoneNumber(textPhone.Text))
            {
                MessageBox.Show("Номер телефона должен содержать только цифры и может начинаться с '+'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var newContact = new Contact(textName.Text, textPhone.Text);

            if (phoneBook.ContainsContact(newContact))
            {
                MessageBox.Show("Такой контакт уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            phoneBook.AddContact(newContact);
            UpdateListBox();
            textName.Clear();
            textPhone.Clear();
        }

        //Кнопка добавления по индексу
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textPhone.Text))
            {
                MessageBox.Show("Введите имя и телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = (int)numericUpDownInsert.Value;
            var newContact = new Contact(textName.Text, textPhone.Text);

            if (!IsValidPhoneNumber(textPhone.Text))
            {
                MessageBox.Show("Номер телефона должен содержать только цифры и может начинаться с '+'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phoneBook.ContainsContact(newContact))
            {
                MessageBox.Show("Такой контакт уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            phoneBook.AddContact(newContact, index-1);
            UpdateListBox();
            textName.Clear();
            textPhone.Clear();
        }

        //Кнопка удаления
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            phoneBook.RemoveContact();
            UpdateListBox();
        }

        //Кнопка удаления по индексу
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int index = (int)numericUpDownRemove.Value;
            phoneBook.RemoveContact(index);
            UpdateListBox();
        }

        //Кнопка сохранения
        private void buttonSave_Click(object sender, EventArgs e)
        {
            PhoneBookLoader.Save(phoneBook, currentFile);
        }

        //Кнопка загрузки
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            PhoneBookLoader.Load(phoneBook, currentFile);
            UpdateListBox();
        }

        //Кнопка выхода
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
