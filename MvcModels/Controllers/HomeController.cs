using System.Web.Mvc;
using MvcModels.Models;
using System.Linq;

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
    }
}