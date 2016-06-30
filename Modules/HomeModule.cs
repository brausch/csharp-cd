using Nancy;
using CdList.Objects;
using System.Collections.Generic;

namespace ToDoList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=>{
        var allCds = Cd.GetAll();
        return View["index.cshtml", allCds];
      };
      Get["/add"]=_=>{
        return View["cd_form.cshtml"];
      };
      Post["/"]=_=>{
        var newCd = new Cd(
        Request.Form["cd-artist"],
        Request.Form["cd-album"]);
        var allCds = Cd.GetAll();
        return View["index.cshtml", allCds];
      };
      Get["/cds/{id}"]=parameters => {
        Cd cd = Cd.Find(parameters.id);
        return View["cd.cshtml", cd];
      };
    }
  }
}
