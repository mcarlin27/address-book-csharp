using Nancy;
using Contacts.Objects;
using System.Collections.Generic;

namespace Contacts.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
    }
  }
}
