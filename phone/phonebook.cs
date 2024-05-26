
using System.Collections.Generic;
using System.Threading.Channels;

public class PhoneBook
{
    private Dictionary<string, string> Contacts { get; }

    public PhoneBook()
    {
        Contacts = new Dictionary<string, string>();
    }

    public void AddContact(string name, string phoneNumber)
    {
        Contacts[name] = name + phoneNumber;
    }

    public void RemoveContact(string name)
    {
        Contacts.Remove(name);
    }

    public Dictionary<string, string> GetAllContacts()
    {
        return Contacts;
    }

    public string FindContactByName(string name)
    {
        if (Contacts.ContainsKey(name))
        {
            return Contacts[name];
        }
        else
        {
            return "Contact not found";
        }
    }

}
