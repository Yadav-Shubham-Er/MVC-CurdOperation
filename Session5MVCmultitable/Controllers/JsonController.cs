using Session5MVCmultitable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Session5MVCmultitable.Controllers
{
    //this is comment from vs
    // this is comment2 from vs
    public class JsonController : Controller
    {
        Session5MVCEntities1 db = new Session5MVCEntities1();
        // GET: Json
       
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create1()
        {
            return View();
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}
        // JsonResult REturn the data in json formate
        public JsonResult GetCities()
        {
            List<string> lst = new List<string>();
            lst.Add("Pune");
            lst.Add("Mumbai");
            lst.Add("Latur");
            lst.Add("Solapur");
            lst.Add("Nashik");// allow the data to pass in json formate
            return Json(lst, JsonRequestBehavior.AllowGet);
            //Json is use for convert the data in json formate
        }

        public JsonResult GetEmployee()
        {
            List<employee_project> temp = db.employee_project.ToList();
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        // code for adding the employee
        public string AddEmployee(employee_project e1)
        {
            db.employee_project.Add(e1);
            db.SaveChanges();
            return "Employee Added Successfully!!!!";

            //try
            //{
            //    db.employee_project.Add(e1);
            //    db.SaveChanges();
            //    return "Employee Added Successfully!!!!";
            //}
            //catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            //{
            //    Exception raise = dbEx;
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            string message = string.Format("{0}:{1}",
            //                validationErrors.Entry.Entity.ToString(),
            //                validationError.ErrorMessage);
            //            // raise a new exception nesting  
            //            // the current instance as InnerException  
            //            raise = new InvalidOperationException(message, raise);
            //        }
            //    }
            //    throw raise;
            //}

        }
        // for update the data
        public JsonResult GetEmployeeById(int id)
        {
            employee_project em = db.employee_project.Find(id);
            return Json(em, JsonRequestBehavior.AllowGet);
        }
        public string UpdateEmployee(employee_project e2)
        {
            db.Entry<employee_project>(e2).State = EntityState.Modified;
            db.SaveChanges();
            return "Employee Updated Successfully!!!!!";
        }
        //--------------------------------------
        public string DeleteEmployee(int id)
        {
            employee_project e3 = db.employee_project.Find(id);
            db.employee_project.Remove(e3);
            db.SaveChanges();
            return "Employee Deleted Successfully!!!!!";
        }
    }
}