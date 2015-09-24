Imports System.Web.Mvc

Namespace Controllers
    Public Class HelloWorldController
        Inherits Controller

        ' GET: HelloWorld
        Function Index() As ActionResult
            Return View()
        End Function

        Function Welcome(name As String, Optional numtimes As Integer = 1, Optional ID As Integer = 1) As ActionResult
            ViewBag.Message = "Hello " & name
            ViewBag.NumTimes = numtimes
            Return View()
            'Return HttpUtility.HtmlEncode("Hello " & name & "; Num Times is : " & numtimes & " ID :" & ID)
        End Function
    End Class
End Namespace