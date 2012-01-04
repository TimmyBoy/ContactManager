using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic;
using Logic.BusinessLogic;
using Raven.Client.Document;
using Raven.Client;
using System.Text.RegularExpressions;
using Logic.Entities;

namespace ContactManager.Controllers
{
    public class PersonManagementController : AbstractController<Person>
    {
        //
        // GET: /PersonManagement/
        static List<Person> personList;

        public ActionResult Details(int id)
        {
            Person person = this.Session.Load<Person>(id);
            return View("Details", person);
        }

        public ActionResult CreatePersonPage()
        {
            return View("CreatePersonPage", new Person());
        }

        public ActionResult PersonOverview()
        {
            personList = this.Session.Query<Person>().ToList();
            return View("PersonOverview", personList);
        }

        public ActionResult EmployeeOverview()
        {
            return View("EmployeeOverview", this.Session.Query<Employee>().ToList());
        }

        [HttpPost]
        public ActionResult CreatePersonPage(Person person)
        {
            //personManager.Create(new Person("Stefanie", "Gegenleithner", "Fabasoft", "Personalmanager", "http://www.fabasoft.at", "stefanie.gegenleithner@gmx.at", "+436642200920", "bla bla bla bla"));
            //string helper= ModifyTelephonnumber(person.TelephoneNumber);
            //this.Add(person);
            //personList = this.Session.Query<Person>().ToList();
            //return View("PersonOverview", personList);
            this.Session.Store(person);
            return RedirectToAction("PersonOverview");
        }

        public ActionResult DeletePerson(int id)
        {
            Person p = this.Session.Load<Person>(id);
            this.Session.Delete<Person>(p);

            personList = this.Session.Query<Person>().ToList();
            return RedirectToAction("PersonOverview");
        }

        public ActionResult EditPerson(int id)
        {
            Person person = this.Session.Load<Person>(id);
            return View("EditPerson", person);
        }

        [HttpPost]
        public ActionResult EditPerson(Person person)
        {
            this.Session.Store(person);

            personList = this.Session.Query<Person>().ToList();
            return RedirectToAction("PersonOverview");
        }

        public string ModifyTelephonnumber(string number)
        {
            return Regex.Replace(number, " ", string.Empty);
        }

        public JsonResult UpdateList(string Searchtext)
        {
            personList = this.Session.Query<Person>().ToList().Where(p => p.Company.ToLower().Contains(Searchtext) ||
                        p.EMail.ToLower().Contains(Searchtext) || p.Firstname.ToLower().Contains(Searchtext) ||
                        p.Surname.ToLower().Contains(Searchtext) || p.TelephoneNumber.ToLower().Contains(Searchtext) ||
                        p.Website.ToLower().Contains(Searchtext)).ToList();
            return Json(new { success = true, redirect = @"PersonManagement\PersonOverview" });
        }
    }
}

