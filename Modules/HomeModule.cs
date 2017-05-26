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
      
    }
  }
}
