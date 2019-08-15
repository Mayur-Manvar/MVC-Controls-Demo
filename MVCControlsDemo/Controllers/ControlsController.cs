using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCControlsDemo.Controllers
{
    public class ControlsController : Controller
    {
        // GET: Controls
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DropdownList()
        {
            List<SelectListItem> listofItem = new List<SelectListItem>();
            listofItem.Add(new SelectListItem { Text = "Super Admin", Value = "Super Admin" });
            listofItem.Add(new SelectListItem { Text = "Admin", Value = "Admin", Selected = true });
            listofItem.Add(new SelectListItem { Text = "Client Admin", Value = "Client Admin" });
            listofItem.Add(new SelectListItem { Text = "Standard", Value = "Standard" });

            ViewBag.UserType = listofItem;
            return View();
        }

        public ActionResult CheckboxList()
        {
            List<MVCControlsDemo.Models.CheckboxList> checkBoxList = new List<MVCControlsDemo.Models.CheckboxList>();
            checkBoxList.Add(new MVCControlsDemo.Models.CheckboxList() { ID = 1, Name = "Mayur", IsSelected = false });
            checkBoxList.Add(new MVCControlsDemo.Models.CheckboxList() { ID = 2, Name = "Jinanda", IsSelected = false });
            checkBoxList.Add(new MVCControlsDemo.Models.CheckboxList() { ID = 3, Name = "Atharv", IsSelected = true });
            checkBoxList.Add(new MVCControlsDemo.Models.CheckboxList() { ID = 4, Name = "Yagnik", IsSelected = false });
            checkBoxList.Add(new MVCControlsDemo.Models.CheckboxList() { ID = 5, Name = "Hetvi", IsSelected = false });

            return View(checkBoxList);
        }

        [HttpPost]
        [ActionName("CheckboxList")]
        public string CheckboxList_Post(IEnumerable<MVCControlsDemo.Models.CheckboxList> cities)
        {
            if (cities.Count(x => x.IsSelected) == 0)
            {
                return "You have not selected any City";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You selected - ");
                foreach (MVCControlsDemo.Models.CheckboxList city in cities)
                {
                    if (city.IsSelected)
                    {
                        sb.Append(city.Name + ", ");
                    }
                }
                sb.Remove(sb.ToString().LastIndexOf(","), 1);
                return sb.ToString();
            }
        }
    }

   

}