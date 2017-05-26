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
      }; //homepage
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      }; //returns list of all contacts
      Get["/category/new"] = _ => {
        return View["category_form.cshtml"];
      }; //returns form for user inputted contact category
      Get["/contact/new"] = _ => {
        return View["category_form.cshtml"];
      }; //returns form for user inputted category, to encourage user to first add categories
      Get["/categories"] = _ => {
        List<Category> allCategories = Category.GetAll();
        return View["categories.cshtml", allCategories];
      }; //returns list of all categories, accessed through link on index.cshtml
      Post["/categories"] = _ => {
        Category newCategory = new Category(Request.Form["category-title"]);
        List<Category> allCategories = Category.GetAll();
        return View["categories.cshtml", allCategories];
      }; //returns list of all categories after form submission
      Get["/categories/{id}"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Category selectedCategory = Category.Find(parameters.id);
        List<Contact> categoryContacts = selectedCategory.GetContacts();
        model.Add("category", selectedCategory);
        model.Add("contacts", categoryContacts);
        return View["category_contacts.cshtml", model];
      }; //returns page depicting single instance of Category constructor
      Get["/categories/{id}/contacts/new"] = parameters => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Category selectedCategory = Category.Find(parameters.id);
        List<Contact> categoryContacts = selectedCategory.GetContacts();
        model.Add("category", selectedCategory);
        model.Add("contacts", categoryContacts);
        return View["category_contact_form.cshtml", model];
      }; //directs user to a form to submit contacts for a particular category
      Post["/contacts"] = _ => {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Category selectedCategory = Category.Find(Request.Form["category-id"]);
        string categoryTitle = selectedCategory.GetTitle();
        List<Contact> categoryContacts = selectedCategory.GetContacts();
        Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-address"], Request.Form["contact-phone"]);
        categoryContacts.Add(newContact);
        model.Add("contacts", categoryContacts);
        model.Add("category", selectedCategory);
        return View["category_contacts.cshtml", model];
      }; //posts user submitted data from new contact form
      Get["/contacts/{id}"] = parameters => {
        Contact selectedContact = Contact.Find(parameters.id);
        return View["contact.cshtml", selectedContact];
      }; //returns page depicting single instance of Contact constructor
    }
  }
}
