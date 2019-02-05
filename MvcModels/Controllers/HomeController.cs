using System.Web.Mvc;
using MvcModels.Models;
using System.Linq;
using System.Collections.Generic;
using System;

namespace MvcModels.Controllers
{
    public class HomeController : Controller
    {
        private Person[] personData = {
            new Person { PersonId=1,FirstName="Adam", LastName="Freeman", Role=Role.Admin},
            new Person { PersonId=2,FirstName="Vadim",LastName="Kisarov", Role=Role.Admin},
            new Person { PersonId=3,FirstName="John",LastName="Smith",Role=Role.User},
            new Person { PersonId=4,FirstName="Anne",LastName="Jones",Role=Role.Guest}
        };

        public ActionResult Index(int id=1){
            Person dataItem = personData.Where(p => p.PersonId == id).First();
            return View(dataItem);
        }

        public ActionResult CreatePerson() {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult CreatePerson(Person model) {
            return View("Index", model);
        }

        public ActionResult DisplaySummary([Bind(Prefix ="HomeAddress", Exclude ="Country")]AddressSummary summary) {
            return View(summary);
        }

        //get and post here
        public ActionResult Names(IList<string> names) {
            //names = names ?? new string[0];
            names = names ?? new List<string>();
            return View(names);
        }

        //custom class
        //public ActionResult Address(IList<AddressSummary> addresses) {
        //    addresses = addresses ?? new List<AddressSummary>();
        //    return View(addresses);
        //}

        //manually model binding
        public ActionResult Address(FormCollection formData) {
            IList<AddressSummary> addresses = new List<AddressSummary>();

            //1 var
            //UpdateModel(addresses, new FormValueProvider(ControllerContext)); //restrict source of data
            //try{
            //    UpdateModel(addresses, formData); //before using parameter "formData"
            //} catch(InvalidOperationException ex) {
            //    //provide feedback to user
            //}

            //2 var
            //if (TryUpdateModel(addresses, formData)){
            //    //procced as normal
            //} else {
            //    //provide feedback to user
            //}

            UpdateModel(addresses); //manually populating instance of addresses
            return View(addresses);
        }
    }
}