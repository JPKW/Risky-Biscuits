<RequireHttps> Public Class HomeController

    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Game() As ActionResult
        ViewData("Message") = "Test"

        Return View()
    End Function

    Function MovieTitle(Genre As String, Decade As String) As String

        MovieTitle = "Risky Business"

    End Function
    Function MovieAmended(Genre As String, Decade As String) As String

        MovieAmended = "Risky Biscuits"

    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
