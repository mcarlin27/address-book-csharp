using System.Collections.Generic;

namespace Contacts.Objects
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phone;
    // private string _category;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};
    public Contact (string name, string address, string phoneNumber)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
      _address = address;
      _phone = phoneNumber;
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
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhoneNumber)
    {
      _phone = newPhoneNumber;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
