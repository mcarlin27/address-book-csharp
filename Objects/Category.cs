using System.Collections.Generic;

namespace Contacts.Objects
{
  public class Category
  {
    private string _title;
    private int _id;
    private static List<Category> _instances = new List<Category> {};
    private List<Contact> _contacts;

    public Category(string categoryTitle)
    {
      _title = categoryTitle;
      _instances.Add(this);
      _id = _instances.Count;
      _contacts = new List<Contact>{};
    }
    public string GetTitle()
    {
      return _title;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Category> GetAll()
    {
      return _instances;
    }
    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public List<Contact> GetContacts()
    {
      return _contacts;
    }
    public void SetContact(Contact contact)
    {
      _contacts.Add(contact);
    }
  }
}
