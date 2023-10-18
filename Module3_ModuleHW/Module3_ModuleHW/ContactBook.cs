using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_ModuleHW
{
    public class ContactBook
    {
        private List<Contact> _book;

        public void AddContact(Contact person)
        {
            if (_book == null)
            {
                _book = new List<Contact>();
            }
            if (!IsContactExist(person))
            {
                _book.Add(person);
            }
        }

        public void RemoveContact(Contact person) 
        {
            if (_book == null) 
            {
                throw new NullReferenceException("Your contact list is empty");
            }

            if (IsContactExist(person)) 
            {
                _book.Remove(person);
            }
        }

        public List<Contact> SearchContactByName(string name)
        {
            return _book.Where(contact => contact.Name == name).ToList();
        }

        public List<Contact> SearchContactBySurname(string surname)
        {
            return _book.Where(contact => contact.Surname == surname).ToList();
        }

        public List<Contact> SearchContactByNumber(string number)
        {
            return _book.Where(contact => contact.PhoneNumber == number).ToList();
        }

        public List<Contact> GetAllContacts() 
        {
            return _book;
        }

        private bool IsContactExist(Contact person) 
        {
            if (_book.Contains(person))
            {
                return true;
                throw new NullReferenceException("Contact don't exist");
            }
            return false;
        }
    }
}
