using System;
using System.IO;
using System.Collections.Generic;

class ContactBook
{
    private string filePath;
    private Dictionary<string, string> contacts;

    public ContactBook(string path)
    {
        filePath = path;
        contacts = new Dictionary<string, string>();
        LoadContacts();
    }

    public void LoadContacts()
    {
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var contactInfo = line.Split(',');
                    contacts[contactInfo[0]] = contactInfo[1];
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read.");
            Console.WriteLine(e.Message);
        }
    }

    public void AddContact(string name, string number)
    {
        contacts[name] = number;
        SaveContacts();
    }

    public string GetContact(string name)
    {
        if (contacts.ContainsKey(name))
        {
            return contacts[name];
        }
        else
        {
            return "Contact not found.";
        }
    }

    public void SaveContacts()
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var contact in contacts)
                {
                    sw.WriteLine($"{contact.Key},{contact.Value}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be written.");
            Console.WriteLine(e.Message);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContactBook cb = new ContactBook("contacts.txt");
        Console.Write("Enter the name: ");
        var name = Console.ReadLine();
        Console.Write("Enter the number: ");
        var number = Console.ReadLine();
        cb.AddContact(name, number);
        Console.WriteLine(cb.GetContact(name));
    }
}