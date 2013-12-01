using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW7.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Form()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            
            items.Add(new SelectListItem { Text = "Luxury", Value = "0", Selected = true });
            items.Add(new SelectListItem { Text = "Standard", Value = "1" });
            items.Add(new SelectListItem { Text = "Economic", Value = "2" });
            ViewBag.RoomType = items;
            
            return View();
        }

        public ActionResult ClientSide()
        {
            return View();
        }

        public ActionResult ServerSide()
        {
            return View();
        }

        public ActionResult Absolute()
        {
            return View();
        }

        public ActionResult Float()
        {
            return View();
        }

        public ActionResult Static()
        {
            return View();
        }



        public ActionResult FormatPhoneNumber(string inputNumber)
        {

            if (string.IsNullOrEmpty(inputNumber))
            {
                string msg = "invalid input, please try again";
                return View((object)msg);
            }
            else if (inputNumber.Length != 10)
            {
                
                string msg = "Please enter 10 digit number, please try again";
                return View((object)msg);
            }
            else
            {
                string formatted = formatNumber(inputNumber);
                formatted = "Your formatted phone number is : " + formatted;
                return View((object)formatted);
            }
        }

        private string formatNumber(string inputNumber)
        {
            char[] cArray = inputNumber.ToCharArray();
            string AreaCode = "(" + inputNumber.Substring(0, 3) + ")";
            string Prefix = " " + inputNumber.Substring(3, 3) + "-";
            string LineNumber = inputNumber.Substring(6, 4);

            string formatted = AreaCode + Prefix + LineNumber;

            return formatted;
        }





        
    }
}
