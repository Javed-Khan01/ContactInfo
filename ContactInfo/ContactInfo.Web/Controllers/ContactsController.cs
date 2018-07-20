using ContactInfo.Data.EFModels;
using ContactInfo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactInfo.Web.Controllers
{
    public class ContactsController : Controller
    {
        private IContactService iContactService;
        public ContactsController(IContactService icontactService)
        {
            iContactService = icontactService;
        }
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Add(Contact contacts)
        {
            try
            {
                contacts.Status = true;
                iContactService.Add(contacts);
            }
            catch(Exception ex)
            {
                return Json(new { Result = "False", Message = ex.Message });
            }
            return Json(new { Result = "True", Message = "Records Added" });
        }
        public JsonResult ContactList(int jtStartIndex, int jtPageSize, string jtSorting = null)
        {
            try
            {
              var contacts=  iContactService.List(jtStartIndex, jtPageSize, jtSorting);
                return Json(new { Result = "OK", Records = contacts, TotalRecordCount = contacts.Count });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
        public JsonResult ActiveDeactive(int ContactId)
        {
            var contacts = iContactService.ActiveDeactive(ContactId);
            return Json(new { Result = "True" });
        }
        public JsonResult Delete(int ContactId)
        {
            var contacts = iContactService.Delete(ContactId);
            return Json(new { Result = "True" });
        }
        public JsonResult Update(Contact contacts)
        {
            try
            {
                iContactService.Update(contacts);
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
            return Json(new { Result = "OK" });
        }
    }
}