<head>
    <style type="text/css">
        #answer {
            height: 33px;
            width: 320px;
        }
    </style>
</head>
@Code
    ViewData("Title") = "About"
End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>


<p>Correct the below movie title:</p>


<p></p>


<input id="answer" type="text" value="Risky Biscuits" style="font-size: 20px"/>

<p></p>

<input id="Submit1" type="submit" value="submit" />