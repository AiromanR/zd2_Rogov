using System.Xml.Linq;

namespace zd2_Rogov
{
    public partial class Form1 : Form
    {
        //�������� ���������� ������
        private PhoneBook phoneBook = new PhoneBook();

        //���� � �����
        private string currentFile = "contacts.csv";
        public Form1()
        {
            InitializeComponent();
            PhoneBookLoader.Load(phoneBook, currentFile);
            UpdateListBox();

            //����������� ��� numericUpDown
            numericUpDownInsert.Maximum = phoneBook.GetContactsCount()+1;
            numericUpDownRemove.Maximum = phoneBook.GetContactsCount();
        }

        //�������� �� ����� � ������
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

        //������� ListBox 
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

        //������� ListBox �� ���������� ��������� (�������� ���������������)
        private void UpdateListBox(List<Contact> contacts)
        {
            listBoxContacts.Items.Clear();
            foreach (var contact in contacts)
            {
                listBoxContacts.Items.Add($"{contact.Name}: {contact.Phone}");
            }
        }

        //������ ������ �� ������
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textSearch.Text)){
                var found = phoneBook.SearchContacts(textSearch.Text.ToLower());
                UpdateListBox(found);
            } else MessageBox.Show("������� ����� ��� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //������ ����������
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textPhone.Text))
            {
                MessageBox.Show("������� ��� � �������", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPhoneNumber(textPhone.Text))
            {
                MessageBox.Show("����� �������� ������ ��������� ������ ����� � ����� ���������� � '+'", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var newContact = new Contact(textName.Text, textPhone.Text);

            if (phoneBook.ContainsContact(newContact))
            {
                MessageBox.Show("����� ������� ��� ����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            phoneBook.AddContact(newContact);
            UpdateListBox();
            textName.Clear();
            textPhone.Clear();
        }

        //������ ���������� �� �������
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textPhone.Text))
            {
                MessageBox.Show("������� ��� � �������", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = (int)numericUpDownInsert.Value;
            var newContact = new Contact(textName.Text, textPhone.Text);

            if (!IsValidPhoneNumber(textPhone.Text))
            {
                MessageBox.Show("����� �������� ������ ��������� ������ ����� � ����� ���������� � '+'", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phoneBook.ContainsContact(newContact))
            {
                MessageBox.Show("����� ������� ��� ����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            phoneBook.AddContact(newContact, index-1);
            UpdateListBox();
            textName.Clear();
            textPhone.Clear();
        }

        //������ ��������
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            phoneBook.RemoveContact();
            UpdateListBox();
        }

        //������ �������� �� �������
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int index = (int)numericUpDownRemove.Value;
            phoneBook.RemoveContact(index);
            UpdateListBox();
        }

        //������ ����������
        private void buttonSave_Click(object sender, EventArgs e)
        {
            PhoneBookLoader.Save(phoneBook, currentFile);
        }

        //������ ��������
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            PhoneBookLoader.Load(phoneBook, currentFile);
            UpdateListBox();
        }

        //������ ������
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
