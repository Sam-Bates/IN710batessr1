using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class HolidayController : Controller
    {
        // GET: Holiday
        public ActionResult Index()
        {
            int nHolidays = 3;
            HolidayModel target;


            HolidayModel halloween = new HolidayModel("Halloween", new DateTime(DateTime.Now.Year, 10, 31), "http://www.foreignersinpoland.com/wp-content/uploads/2014/09/halloween-pumpkin.jpg");

            HolidayModel boxingDay = new HolidayModel("Boxing Day", new DateTime(DateTime.Now.Year, 12, 26), "http://i.telegraph.co.uk/multimedia/archive/01795/ali_1795027b.jpg");

            HolidayModel queensBirthday = new HolidayModel("Queens Birthday", new DateTime(DateTime.Now.Year, 06, 06), "http://www.crossfitanarchy.com.au/uploads/1/3/0/8/13080067/7638354_orig.jpg");


            Random r = new Random();

            target = new HolidayModel();//this seems very bad lol

            switch (r.Next(nHolidays))//choose random holiday and switch
            {
                case 0:
                    target = halloween;
                    break;
                case 1:
                    target = boxingDay;
                    break;
                case 2:
                    target = queensBirthday;
                    break;
            }

            target.DaysUntil = (int)(target.Date - DateTime.Now).TotalDays;

            return View(target);
        }
    }
}