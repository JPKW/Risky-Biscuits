Imports System.Web.Mvc

Namespace Controllers
    Public Class GameController
        Inherits Controller

        ' GET: Game
        Function Game() As ActionResult
            ViewData("Message") = "Test."

            Return View()
        End Function
    End Class
End Namespace