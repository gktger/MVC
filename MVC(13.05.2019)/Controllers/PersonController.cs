using MVC_13._05._2019_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_13._05._2019_.Controllers
{
    public class PersonController : Controller
    {
       
        public ActionResult Index()
        {
            PersonModel model = new PersonModel();
            model.Name = "Göktuğ Erçalışkan";
            model.BirthDate = new DateTime(1989,10,14);

            model.GsmNumberList = new List<string>();
            model.GsmNumberList.Add("8181818");
            model.GsmNumberList.Add("55511115151");
            model.GsmNumberList.Add("895445621");



            model.AdressList = new List<string>();
            model.AdressList.Add("Mahmut tuncer sokak");
            model.AdressList.Add("sokak cadde");





            return View(model);
        }
    }
}