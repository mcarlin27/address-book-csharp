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
      Post["/categories"] = _ => {
        Category newCategory = new Category(Request.Form["category-title"]);
        List<Category> allCategories = Category.GetAll();
        return View["categories.cshtml", allCategories];
      };
      // Post["/categories/{id}"] = parameters => {
      //   Dictionary<string, object> model = new Dictionary<string, object>();
      //   Category newCategory = new Category(Request.Form["category-title"]);
      //   List<Category> allCategories = Category.GetAll();
      //   Category selectedCategory = Category.Find(parameters.id);
      //   List<Contact> categoryContacts = selectedCategory.ViewContacts();
      //   model.Add("category", selectedCategory);
      //   model.Add("contacts", categoryContacts);
      //   return View["index.cshtml", model];
      // };
    }
  }
}
