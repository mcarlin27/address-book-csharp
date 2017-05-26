using Nancy;
using Contacts.Objects;
using System.Collections.Generic;

namespace Contacts.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };
      Get["/category/new"] = _ => {
        return View["category_form.cshtml"];
      };
    }
  }
}
