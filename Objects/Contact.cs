using System.Collections.Generic;

namespace Contacts.Objects
{
  public class Contact
  {
    private string _name;
    // private string _address;
    // private string _phone;
    // private string _category;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};
    public Contact (string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
      // _address = address;
      // _phone = phone;
      // _category = category;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName (string newName)
    {
      _name = newName;
    }
    public static List<Contact> GettAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
  }
}
