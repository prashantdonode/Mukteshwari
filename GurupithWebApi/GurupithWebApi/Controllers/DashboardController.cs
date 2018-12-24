using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GurupithWebApi.Entity;

namespace GurupithWebApi.Controllers
{
    public class DashboardController : Controller
    {
        GurupithEntities _db = new GurupithEntities();
        InformationApiController _objInfo = new InformationApiController();




        public ActionResult Index()
        {
            return View();
        }


        #region Display all tblReg Data

        public ActionResult DisplayRegData()
        {
            var result = _objInfo.RegInfo();

            return View(result.Result.Response);
        }

        #endregion


        #region Search Information By Name

        public ActionResult SearchInfo(string search)
        {
            personal_information model = new personal_information();

            model.nameofperson = search;

            var result = _objInfo.SearchPersonalInfo(model);


            return View(result.Result.Response);
        }

        #endregion



        #region comments
        /*
         if (option == "Subjects")
            {
                //Index action method will return a view with a student records based on what a user specify the value in textbox  
                return View(_db.personal_information.Where(x => x.nameofperson == search || search == null).ToList());
            }
            else if (option == "Name")
            {
                return View(_db.personal_information.Where(x => x.nameofperson.StartsWith(search) || search == null).ToList());
            }
            else
            {
                return View(_db.personal_information.Where(x => x.city==search || search == null).ToList());
            }
            
         */
        #endregion

    }
}