using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }

        public PartialViewResult PartialExperience()
        {
            var values = db.TblExperience.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEducation()
        {
            var values = db.TblEducation.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkills()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialHobby()
        {
            var values = db.TblHobbys.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialCertificate()
        {
            var values = db.TblCertificate.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialContact()
        {
          
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialContact(TblContact contact)
        {
            db.TblContact.Add(contact);
            db.SaveChanges();
            return PartialView();
        }
    }
}