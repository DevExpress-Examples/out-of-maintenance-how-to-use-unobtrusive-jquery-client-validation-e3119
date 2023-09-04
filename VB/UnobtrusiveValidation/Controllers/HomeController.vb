Imports System.Web.Mvc
Imports JQueryValidation.Models
Imports DevExpress.Web.Mvc

Namespace JQueryValidation.Controllers

    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return UnobtrusiveValidation()
        End Function

        <AcceptVerbs(HttpVerbs.Get)>
        Public Function UnobtrusiveValidation() As ActionResult
            Return View("UnobtrusiveValidation", New ValidationData())
        End Function

        <AcceptVerbs(HttpVerbs.Post)>
        Public Function UnobtrusiveValidation(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal validationData As ValidationData) As ActionResult
            If ModelState.IsValid Then Return View("UnobtrusiveValidationSuccess")
            Return View("UnobtrusiveValidation", validationData)
        End Function

        Public Function UnobtrusiveValidationSuccess() As ActionResult
            Return View("UnobtrusiveValidationSuccess")
        End Function
    End Class
End Namespace
