using System;
using System.Web;
using System.Web.Mvc;
using JQueryValidation.Models;
using DevExpress.Web.Mvc;

namespace JQueryValidation.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return UnobtrusiveValidation();
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult UnobtrusiveValidation() {
            return View("UnobtrusiveValidation", new ValidationData());
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UnobtrusiveValidation([ModelBinder(typeof(DevExpressEditorsBinder))] ValidationData validationData) {
            if(ModelState.IsValid)
                return View("UnobtrusiveValidationSuccess");
            return View("UnobtrusiveValidation", validationData);
        }
        public ActionResult UnobtrusiveValidationSuccess() {
            return View("UnobtrusiveValidationSuccess");
        }
    }
}
